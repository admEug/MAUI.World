using SQLite;

namespace SQLITEDemo
{
	public static class Constants
     {
          private const string DBFileName = "SQLite.db3";

          public const SQLiteOpenFlags Flags =
               SQLiteOpenFlags.ReadWrite |
               SQLiteOpenFlags.Create |
               SQLiteOpenFlags.SharedCache;

          public static string DatabasePath
          {
               get
               {
                    var newPath = Path
						 .Combine(FileSystem.AppDataDirectory, DBFileName);
                    return newPath;
               }
          }
     }
}
