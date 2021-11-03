using MySql.Data.MySqlClient;

namespace mysql {
  class bancoMySQL {
    private MySqlConnection mConn;
    private MySqlDataAdapter mAdapter;
    // private string DATABASE = System.Environment.GetEnvironmentVariable("DATABASE");
    // private string DBSERVER = System.Environment.GetEnvironmentVariable("DBSERVER");
    // private string DBUSER = System.Environment.GetEnvironmentVariable("DBUSER");
    // private string DBPASS = System.Environment.GetEnvironmentVariable("DBPASS");
    // private string strConn = "Persist Security Info=False;server=" + DBSERVER + ";database=" + DATABASE + ";uid=" + DBUSER + ";pwd=" + DBPASS;
    private string strConn = "Persist Security Info=False;server=localhost;database=aplication;uid=root;pwd=*B14g1t4k";
    public bancoMySQL () {
      mConn = new MySqlConnection(strConn);
      try {
        //abre a conexao
        mConn.Open();
        System.Console.WriteLine("Banco de dados acessado com sucesso;");
      }
      catch(System.Exception e) {
        System.Console.WriteLine(e.Message.ToString());
      }
      //verificva se a conexão esta aberta
      if (mConn.State == System.Data.ConnectionState.Open) {
        //cria um adapter usando a instrução SQL para acessar a tabela Clientes
        mAdapter = new  MySqlDataAdapter("SHOW databases", mConn);
      }
    }
  }
  class consultarBanco {}
  class inserirBanco {}
  class alterarBanco {}
}