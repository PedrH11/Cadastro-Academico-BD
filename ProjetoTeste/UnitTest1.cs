using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace ProjetoTeste
{
    [TestClass]
    public class UnitTest1
    {
        public MySqlConnection GetConnection()
        {
            string c = @"server= 127.0.0.1;" +
                       "uid=root;" +
                       "pwd=Tiao1108@;" +
                       "database=academico";
            return new MySqlConnection(c);
        }
        [TestMethod]
        public void TestConnect()
        {
            var con = GetConnection();  
            con.Open();
            Assert.IsTrue(con.State == System.Data.ConnectionState.Open);
            
        }

        [TestMethod]
        public void TestInsert()
        {
            string sql = "INSERT INTO aluno " +
                " (matricula, nome, dt_nascimento, endereco, " +
                " bairro, cidade, estado, senha) " +
                " VALUES " +
                " (@matricula, @nome, @dt_nascimento, @endereco, " +
                " @bairro, @cidade, @estado, @senha)";
            var con = GetConnection();
            con.Open();
            var cmd = new MySqlCommand(sql,con);

            cmd.Parameters.AddWithValue("@matricula", "BI112616");
            cmd.Parameters.AddWithValue("@nome", "Pedro Batista");
            cmd.Parameters.AddWithValue("@dt_nascimento", new DateTime(2002,10,13));
            cmd.Parameters.AddWithValue("@endereco", "Rua Pedro Cavalo 789");
            cmd.Parameters.AddWithValue("@bairro", "Portal da Pérola");
            cmd.Parameters.AddWithValue("@cidade", "Birigui");
            cmd.Parameters.AddWithValue("@estado", "SP");
            cmd.Parameters.AddWithValue("@senha", "123456");
            cmd.Prepare();  //verifica se as instruções estão certas
            cmd.ExecuteNonQuery(); //executa e retorna num de linhas que inseriu
        }

        [TestMethod]
        public void TesteSelect()
        {
            var con = GetConnection();
            con.Open();

            var sql = "SELECT * from aluno";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);

            var dt = new DataTable();
            sqlAd.Fill(dt);

            foreach(DataRow dr in dt.Rows)
            {
                Debug.Write(dr["matricula"]+ " ");
                Debug.Write(dr["nome"] + " ");
                Debug.Write(dr["dt_nascimento"] + " ");
                Debug.Write(dr["endereco"] + " ");
                Debug.Write(dr["bairro"] + " ");
                Debug.Write(dr["cidade"] + " ");
                Debug.Write(dr["estado"] + " ");
                Debug.Write(dr["senha"] + " ");
                Debug.WriteLine(" ");
            }
        }
    }
}