using cspModCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cspOptometry.Repositories
{
  public class InputRepository
  {
    public static DataTable GetDataTable(string chart, string symd, string eymd)
    {
      var inVarArr = Enumerable.Range(1, 100).Select((x) => $"in_var{x}");
      string sql = $@"
SELECT in_gubun, in_ymd, in_time, in_dup, in_rl, in_section, {string.Join(", ", inVarArr)} FROM input
WHERE in_header = '0'
AND in_chart = '{chart}'
AND in_ymd >= '{symd}'
AND in_ymd <= '{eymd}'
AND in_dc <> '1' 
ORDER BY in_gubun, in_ymd DESC, in_dup";
      using (var maria = new CsMaria(modCommon.WSREC.DBDir))
      using (DataTable dt = maria.GetDataTable(sql))
      {
        return dt;
      }      
    }
  }
}
