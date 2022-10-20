using cspModCommon;
using static cspModCommon.modCommon;

namespace cspOptometry.Repositories
{
  public class InfoSchemaRepository
  {
    public static bool TableExists(string database, string tableName )
    {
      string query = $@"
SELECT 1 FROM information_schema.TABLES
WHERE TABLE_SCHEMA = '{database}'
AND TABLE_NAME ='{tableName}'";
      using (var maria = new CsMaria(WSREC.DBDir))
      using (var dr = maria.GetReader(query))
        return dr.Read();
    }
  }
}
