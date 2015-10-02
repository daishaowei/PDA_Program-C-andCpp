using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

[WebService(Namespace = "http://text.com/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service () 
    {
        
    }
         [WebMethod]
        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
        public string reader()
        {
            String con = @"Server = 172.20.10.6;Data Source = SKY-20150825QBS\SQLEXPRESS;Database = DATA;UID = sa;PWD = 1234";
            SqlConnection connection = new SqlConnection(con);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT*from Table_1";
            command.CommandType = CommandType.Text;
            string count = Convert.ToString(command.ExecuteScalar());
            return count;
        }
    

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    
}
