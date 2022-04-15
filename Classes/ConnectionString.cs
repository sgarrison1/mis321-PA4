namespace mis321_pa4
{
    public class ConnectionString
    {
         public string cs {get;set;}
        public ConnectionString()
        {
            string server = "l6glqt8gsx37y4hs.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "onylndqihraewdbq";
            string port = "3306";
            string userName = "axi8fzzfgmbqoji5";
            string password = "tu9v6fb3j1siqj7l";

            cs = $@"server = {server}; user = {userName}; database = {database}; port = {port}; password = {password};";

        }
    }
}