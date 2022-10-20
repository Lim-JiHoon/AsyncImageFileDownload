using ConvenientLib.Common.Sqls;
using System.Data;
using System.Drawing;
using static cspModCommon.modCommon;

namespace cspOptometry.Models
{
  public class Cap
  {
    public long Auto { get; set; }
    public long Caauto { get; set; }
    public string Chart { get; set; }
    public string Yuhyung { get; set; }
    public string Ymd { get; set; }
    public string Gubun { get; set; }
    public string Etc { get; set; }
    public int No { get; set; }
    public string Path { get; set; }
    public string Index { get; set; }
    public byte[] Image { get; set; }
    public string Dc { get; set; }
    public string Indate { get; set; }
    public string Update { get; set; }
    public string Dcdate { get; set; }
    public string Inuser { get; set; }
    public string Upuser { get; set; }
    public string Dcuser { get; set; }
    public string Etc1 { get; set; }
    public string Etc2 { get; set; }
    public string Etc3 { get; set; }
    public string Etc4 { get; set; }
    public string Etc5 { get; set; }

    public Image GetImage()
    {
      if(Image != null)
      {
        var decompBuffer = DecompressByte_FromByte(Image);
        return ImgLoad(decompBuffer);
      }
      else
      {
        return null;
      }
    }

    public Cap(IDataReader dr)
    {
      DataReaderEx.SetProperties(this, dr);
    }
  }
}
