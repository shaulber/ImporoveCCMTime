using System;

namespace ImproveCCMUploadTime
{
    public enum DatabaseType // PostgreSQL/Oracle/MS-SQL/Sybase
    {
        None,
        PostgreSQL,
        Oracle,
        MSSQL,
        Sybase
    };

    public static class DatabaseTypeHelper
    {
        #region static/readonly

        public const string dbPG = "PG";

        // ui display, new display names
        public const string dbPgSQL = "PostgreSQL";
        public const string dbOracle = "Oracle";
        public const string dbMsSQL = "MS-SQL";
        public const string dbSybase = "Sybase";

        // old display names, used in plugins
        public const string dbPgSQL2 = "POSTGRESQL";
        public const string dbOracle2 = "ORACLE_OCI";
        public const string dbMsSQL2 = "MS_SQL";
        public const string dbSybase2 = "SYBASE_CT";

        #endregion

        // returned database display name from database type
        // ui_display=true: database display name used in ccm (new code)
        // ui_display=true: database display name as used in plugins (old code)
        public static string GetDatabaseKeyFromType(DatabaseType dbType, bool ui_display = false)
        {
            switch (dbType)
            {
                case DatabaseType.PostgreSQL:
                    return ui_display ? dbPgSQL : dbPgSQL2;
                case DatabaseType.Oracle:
                    return ui_display ? dbOracle : dbOracle2;
                case DatabaseType.MSSQL:
                    return ui_display ? dbMsSQL : dbMsSQL2;
                case DatabaseType.Sybase:
                    return ui_display ? dbSybase : dbSybase2;

                default:
                    return string.Empty;
            }
        }

        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }

        // return database enum type from display name 
        public static DatabaseType GetDatabaseTypeFromKey(string dbKey)
        {
            if (string.IsNullOrEmpty(dbKey))
                return DatabaseType.None;

            if (dbKey.Contains("postg", StringComparison.OrdinalIgnoreCase))
                return DatabaseType.PostgreSQL;

            if (dbKey.Contains("pg", StringComparison.OrdinalIgnoreCase))
                return DatabaseType.PostgreSQL;

            if (dbKey.Contains("ora", StringComparison.OrdinalIgnoreCase))
                return DatabaseType.Oracle;

            if (dbKey.Contains("ms", StringComparison.OrdinalIgnoreCase))
                return DatabaseType.MSSQL;

            if (dbKey.Contains("syb", StringComparison.OrdinalIgnoreCase))
                return DatabaseType.Sybase;

            else return DatabaseType.None;
        }

        public static bool IsDbTypePG(string key) { return GetDatabaseTypeFromKey(key) == DatabaseType.PostgreSQL; }
        public static bool IsDbTypeOracle(string key) { return GetDatabaseTypeFromKey(key) == DatabaseType.Oracle; }
        public static bool IsDbTypeMSSQL(string key) { return GetDatabaseTypeFromKey(key) == DatabaseType.MSSQL; }
        public static bool IsDbTypeSybase(string key) { return GetDatabaseTypeFromKey(key) == DatabaseType.Sybase; }
    }
}
