// Tutorial seguido no link abaixo:
// https://zetcode.com/csharp/postgresql/

using System;
using Npgsql;

namespace postgreSQL {
  class iniciarBanco {
    private string connStr = "Host=localhost;Username=postgres;Password=*B14g1t4k;Database=aplication";
    public iniciarBanco () {
      var con = new NpgsqlConnection(connStr);
      con.Open();
      var sql = "SELECT version()";
      var cmd = new NpgsqlCommand(sql, con);
      var version = cmd.ExecuteScalar().ToString();
      System.Console.WriteLine($"PostgreSQL version: {version}");
    }
  }
}
