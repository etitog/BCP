namespace MetaUI.Data
{
    public class SqlConfiguration
    {
        public SqlConfiguration(string connectionString) => ConnectionString = connectionString;
        public String ConnectionString { get; }
    }
}
