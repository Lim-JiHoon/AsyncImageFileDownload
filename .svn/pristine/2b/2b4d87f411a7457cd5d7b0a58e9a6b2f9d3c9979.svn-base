using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cspOptometry.Utils
{
  public class SettingUtils
  {
    public static string MyopiaSaveDir
    {
      get => new Properties.Settings().MyopiaSaveDir;
      set
      {
        Properties.Settings settings = new Properties.Settings();
        settings.MyopiaSaveDir = value;
        settings.Save();
      }
    }
  }
}
