using MODERN_GUI_2.Auxiliar;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODERN_GUI_2.Model
{
    class Categorias
    {
        public int idCategoria { get; set; }
        public string Categoria { get; set; }


        public bool Cadastrar(Categorias categorias)
        {
            bool flag = false;
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {

                con.Open();
                MySqlCommand commd = new MySqlCommand("CadastroCategoria", con);

                commd.Parameters.AddWithValue("@NomeCategoria", categorias.Categoria);

                commd.CommandType = CommandType.StoredProcedure;
                try
                {
                    int i = commd.ExecuteNonQuery();
                    if (i > 0)
                        flag = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex);
                    flag = false;
                }


                return flag;
            }
        }
        public DataTable popularComboBox()
        {
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {

                con.Open();
                MySqlCommand commd = new MySqlCommand("SELECT * FROM tb_categoria", con);
                DataTable dataTable = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = commd;
                dataTable.Clear();
                ad.Fill(dataTable);

                return dataTable;
            }
        }
        public DataSet retorna()
        {
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {

                con.Open();
                MySqlCommand commd = new MySqlCommand("SELECT idCategoria AS ID, NomeCategoria AS Categoria FROM tb_categoria", con);
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = commd;
                DataSet dataSet = new DataSet();
                ad.Fill(dataSet);

                return dataSet;
            }

        }
        public bool Atualizar(Categorias categorias)
        {
            bool flag = false;
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {

                con.Open();
                MySqlCommand commd = new MySqlCommand("UPDATE tb_categoria SET NomeCategoria = ? WHERE idCategoria = ?", con);

                commd.Parameters.AddWithValue("@NomeCategoria", categorias.Categoria);
                commd.Parameters.AddWithValue("@idCategoria", categorias.idCategoria);

                MySqlDataReader adapter = commd.ExecuteReader();
                try { 
                    flag = true;
                    
                }catch(Exception e)
                {
                    Console.WriteLine("Erro" + e);
                    flag = false;

                }

                return flag;
            }
        }
    }
}
