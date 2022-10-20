using cspModCommon;
using System;
using static cspModCommon.modCommon;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvenientLib.Common.Extensions;

namespace cspOptometry.Repositories
{
  public class CaRepository
  {
    public async static Task<(DateTime sDte, DateTime eDte)> GetDateRange(string chart)
    {
      Func<(DateTime sDte, DateTime eDte)> GetDefaultVtp = () => (default(DateTime), default(DateTime));

      
      string query = $@"
SELECT MIN(ca_ymd) minymd, MAX(ca_ymd) maxymd FROM ca
WHERE ca_chart = '{chart}'
AND ca_gubun = 'S' ";
      using (var maria = new CsMaria(WSREC.DBDir))
      using (var dr = await maria.GetReaderAsync(query))
      {
        if (dr.Read())
        {
          var minymd = (string)dr.Get("minymd");
          var maxymd = (string)dr.Get("maxymd");
          if (minymd ==null || maxymd == null)
            return GetDefaultVtp();

          return ((minymd.ToDateTime(), maxymd.ToDateTime()));
        }
        else
        {
          return GetDefaultVtp();
        }
      }
    }
  }
}
