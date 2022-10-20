using System;
using cspModCommon;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cspOptometry.Repositories;
using cspOptometry.Models;
using System.Drawing;
using cspOptometry.Utils;
using System.IO;
using System.Drawing.Imaging;
using static cspModCommon.modCommon;
using FarPoint.Win.Spread;
using FarPoint.Excel;

namespace cspOptometry.Controllers
{
  public class MyopiaController
  {
    #region fields
    private const string CSVTEMPNAME = "Temp.csv";
    private const string LEFTJPGNAME = "Fundus_L.jpg";
    private const string RIGHTJPGNAME = "Fundus_R.jpg";
    private IMyopia _view;
    private string _chart;
    #endregion

    #region private methods
    private void SetChartInfo()
    {
      var wj = cspModCommon.WjData.GetModel(_chart, fromQuery: "wj_suname");
      _view.SetInfo(_chart, wj.suname);
    }

    private async Task LoadImages(DateTime sDte, DateTime eDte)
    {
      var tasks = new List<Task<List<Cap>>>();
      for (int y = sDte.Year; y <= eDte.Year; y++)
      {
        string capTbl = $"cap{y}";
        if (InfoSchemaRepository.TableExists(modCommon.WSREC.DBDir, capTbl))
        {
          var task = Task.Run(() => CapRepository.GetCaps(_chart, capTbl, $"{sDte:yyyyMMdd}", $"{eDte:yyyyMMdd}"));
          tasks.Add(task);
        }
      }

      List<Cap> caps = new List<Cap>();
      var results = await Task.WhenAll(tasks);
      foreach (var result in results)
        caps.AddRange(result);

      caps = (from s in caps orderby s.Ymd descending, s.No select s).ToList();

      _view.LoadImages(caps);
    }

    private void DeleteFilesInDir(DirectoryInfo di)
    {
      foreach (FileInfo file in di.GetFiles())
      {
        try
        {
          file.Delete();
        }
        catch { }
      }
    }
    #endregion

    #region constructor 
    public MyopiaController(IMyopia view, string chart)
    {
      _view = view;
      _chart = chart;
      _view.SetController(this);
      SetChartInfo();
    }
    #endregion

    #region internal
    internal async Task Search()
    {
      await Task.Delay(1);
      var dteRange = await CaRepository.GetDateRange(_chart);
      if (dteRange.sDte == default(DateTime))
      {
        _view.Clear();
        return;
      }
      await Search(dteRange.sDte, dteRange.eDte);
    }

    internal void LoadInputs(string lymd, string rymd)
    {
      var ymds = new string[] { lymd, rymd };
      var inputDt = InputRepository.GetDataTable(_chart, ymds.Min(), ymds.Max());
      var wj = WjData.GetModel(_chart);
      
      _view.LoadInputs(wj, inputDt);
    }

    internal async Task Search(DateTime sDte, DateTime eDte)
    {
      _view.Clear();
      await LoadImages(sDte, eDte);
    }

    internal void SaveFiles(Image leftImage, Image rightImage, FpSpread spread)
    {
      string dirPath = SettingUtils.MyopiaSaveDir;
      if (dirPath == "")
      {
        Msg("저장경로를 먼저 설정하세요.!!");
        return;
      }
      DirectoryInfo di = new DirectoryInfo(dirPath);
      if (!di.Exists) di.Create();

      DeleteFilesInDir(di);
      string leftFilePath = Path.Combine(di.FullName, LEFTJPGNAME);
      string rightFilePath = Path.Combine(di.FullName, RIGHTJPGNAME);
      using (var bmp = new Bitmap(leftImage))
        bmp.Save(leftFilePath, ImageFormat.Jpeg);
      using (var bmp = new Bitmap(rightImage))
        bmp.Save(rightFilePath, ImageFormat.Jpeg);

      string excelFilePath = Path.Combine(di.FullName, CSVTEMPNAME);
      ExcelSaveFlags excelFlag = ExcelSaveFlags.SaveAsViewed;
      spread.SaveExcel(excelFilePath, excelFlag);

      Msg("저장되었습니다.!!");
    }
    #endregion   
  }
}