using cspModCommon;
using cspOptometry.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cspOptometry.Controllers
{
  public interface IMyopia
  {
    void SetController(MyopiaController controller);
    void SetInfo(string chart, string suname);
    void LoadImages(List<Cap> caps);
    void Clear();
    void LoadInputs(WjModel wj, DataTable dt);
  }
}
