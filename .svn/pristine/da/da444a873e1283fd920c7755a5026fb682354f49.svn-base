using ConvenientLib.Common.Extensions;
using cspModCommon;
using cspOptometry.Models;
using System.Collections.Generic;
using static cspModCommon.modCommon;

namespace cspOptometry.Repositories
{
  public class CapRepository
  {
    public static List<Cap> GetCaps(string chart, string capTbl, string symd, string eymd)
    {
      var caps = new List<Cap>();      

      using (var maria = new CsMaria(WSREC.DBDir))
      {
        string query = $@"
SELECT cap_ymd, cap_etc, cap_no, cap_image FROM ca
INNER JOIN {capTbl}
ON ca_auto = cap_caauto
WHERE ca_chart = '{chart}' 
AND ca_ymd <= '{eymd}'
AND ca_ymd >= '{symd}'
AND ca_dc <> '1' ";
        using (var dr = maria.GetReader(query))
        {
          while (dr.Read())
          {
            caps.Add(new Cap(dr));
          }
          return caps;
        }
      }
    }
  }
}
