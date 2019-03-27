using MODERN_GUI_2.Auxiliar;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODERN_GUI_2.Controller
{
    class ControladorLogar
    {
        public bool Autenticar(Usuario user)
        {
            bool flag = false;
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {
                
                con.Open();
                MySqlCommand commd = new MySqlCommand("SELECT * FROM tb_user WHERE Username = ? AND Password = ?", con);
              
                commd.Parameters.AddWithValue("@Username", user.username);
                commd.Parameters.AddWithValue("@Password", user.password);

                MySqlDataReader adapter = commd.ExecuteReader();
                if (adapter.HasRows)
                {
                    flag = true;
                    MessageBox.Show("Logado com sucesso", "Logado");
                    FormMenu formMenu = new FormMenu();
                    formMenu.Show();
                    ControladorProduto controladorProduto = new ControladorProduto();
                    controladorProduto.verificaEstoqueInicializacao();
                }
                else
                {
                    MessageBox.Show("Erro ao logar");

                }


                return flag;
            }
        }

       
    }
}
