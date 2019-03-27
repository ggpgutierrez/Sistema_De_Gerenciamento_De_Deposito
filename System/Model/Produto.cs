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
    class Produto
    {
        public string idProduto { get; set; }
        public string nomeProduto { get; set; }
        public string ValorUnit { get; set; }
        public string Qtd { get; set; }
        public string TipoProduto { get; set; }
        public string UnidadeMedida { get; set; }
        public string DescricaoProduto { get; set; }

        public bool Cadastrar(Produto produtos)
        {
            bool flag = false;
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {

                con.Open();
                MySqlCommand commd = new MySqlCommand("CadastroProduto", con);
                commd.Parameters.AddWithValue("@NomeProduto", produtos.nomeProduto);
                commd.Parameters.AddWithValue("@ValorUnit", produtos.ValorUnit);
                commd.Parameters.AddWithValue("@TipoProdutoFK", produtos.TipoProduto);
                commd.Parameters.AddWithValue("@UnidadeMedida", produtos.UnidadeMedida);
                commd.Parameters.AddWithValue("@DescricaoProduto", produtos.DescricaoProduto);
                commd.Parameters.AddWithValue("@Quantidade", produtos.Qtd);


                commd.CommandType = CommandType.StoredProcedure;
                try
                {
                    int i = commd.ExecuteNonQuery();
                    if (i > 0)
                        flag = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro" + ex);
                    flag = false;
                }


                return flag;
            }
        }
        public bool Atualizar(Produto produtos)
        {
            bool flag = false;
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {

                con.Open();
           
                MySqlCommand commd = new MySqlCommand("UPDATE `tb_produto` SET `NomeProduto` = ?, `ValorUnit` = ?, `TipoProdutoFK` = ?, `UnidadeMedida` = ?, `DescricaoProduto` = ?, `Quantidade` = ? WHERE `id_Produto` = ?", con);
                commd.Parameters.AddWithValue("@NomeProduto", produtos.nomeProduto);
                commd.Parameters.AddWithValue("@ValorUnit", produtos.ValorUnit);
                commd.Parameters.AddWithValue("@TipoProdutoFK", produtos.TipoProduto);
                commd.Parameters.AddWithValue("@UnidadeMedida", produtos.UnidadeMedida);
                commd.Parameters.AddWithValue("@DescricaoProduto", produtos.DescricaoProduto);
                commd.Parameters.AddWithValue("@Quantidade", produtos.Qtd);
                commd.Parameters.AddWithValue("@id_Produto", produtos.idProduto);

                try
                {
                    MySqlDataReader adapter = commd.ExecuteReader();
                    flag = true;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro" + e);
                    flag = false;

                }
                return flag;
            }
         }
        public DataSet retorna()
        {
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {

                con.Open();
                MySqlCommand commd = new MySqlCommand("SELECT p.id_Produto AS ID, p.NomeProduto AS Produto, p.ValorUnit AS Valor, c.NomeCategoria AS Tipo,p.Quantidade AS Qtd, p.UnidadeMedida AS 'Unidade de Medida', p.DescricaoProduto AS 'Detalhamento'" +
                    "FROM tb_produto AS p INNER JOIN tb_categoria AS c ON p.TipoProdutoFK = c.idCategoria", con);
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = commd;
                DataSet dataSet = new DataSet();
                ad.Fill(dataSet);

                return dataSet;
            }

        }
        public DataSet retornaFiltro(string opcao, string texto)
        {
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {
                MySqlCommand commd = new MySqlCommand("");
                con.Open();
                if (opcao == "Nome")
                {
                   commd = new MySqlCommand("SELECT p.id_Produto AS ID, p.NomeProduto AS Produto, p.ValorUnit AS Valor, c.NomeCategoria AS Tipo,p.Quantidade AS Qtd, p.UnidadeMedida AS 'Unidade de Medida', p.DescricaoProduto AS 'Detalhamento'" +
                        "FROM tb_produto AS p INNER JOIN tb_categoria AS c ON p.TipoProdutoFK = c.idCategoria WHERE p.NomeProduto LIKE " + "'%"+texto+"%'", con);
                }
                else
                {
                    commd = new MySqlCommand("SELECT p.id_Produto AS ID, p.NomeProduto AS Produto, p.ValorUnit AS Valor, c.NomeCategoria AS Tipo,p.Quantidade AS Qtd, p.UnidadeMedida AS 'Unidade de Medida', p.DescricaoProduto AS 'Detalhamento'" +
                        "FROM tb_produto AS p INNER JOIN tb_categoria AS c ON p.TipoProdutoFK = c.idCategoria WHERE c.NomeCategoria LIKE " + "'%" + texto + "%'", con);
                }
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = commd;
                DataSet dataSet = new DataSet();
                ad.Fill(dataSet);

                return dataSet;
            }

        }

        public List<String>VerificarEstoque()
        {
            List<String> produtos = new List<String>();
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {

                con.Open();
                MySqlCommand commd = new MySqlCommand("SELECT NomeProduto FROM `tb_produto` WHERE Quantidade <= 4", con);
                MySqlDataReader reader = commd.ExecuteReader();
                while (reader.Read())
                {
                    produtos.Add(reader.GetString(0));
                }
            }
            return produtos;
        }
        public string CaixaSemanal()
        {
            string valor = "";

            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {
                con.Open();
                MySqlCommand commd = new MySqlCommand("SELECT CASE WHEN FORMAT(SUM(prod.ValorUnit * i.Quantidade), 2)  IS NULL THEN 'NULO' WHEN FORMAT(SUM(prod.ValorUnit * i.Quantidade),2) > 0 THEN FORMAT(SUM(prod.ValorUnit * i.Quantidade),2)  END FROM tb_pedido AS p INNER JOIN tb_itenspedido AS i ON p.id_pedido = i.Id_PedidoFK " +
                    "INNER JOIN tb_produto AS prod ON prod.id_Produto = i.Id_ProdutoFK " +
                    "WHERE CONVERT(p.Data_Pedido, char(10)) <= Convert(CURRENT_DATE()-7, char(10))", con);
                MySqlDataReader reader = commd.ExecuteReader();
                while (reader.Read())
                {
                    valor = reader.GetString(0);
                }
                if (valor == "NULO")
                {
                    valor = "0,00";
                }
            }
            return valor;
        }
        public string CaixaDia()
        {
            string valor = "";

            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {
                con.Open();
                MySqlCommand commd = new MySqlCommand("SELECT CASE WHEN FORMAT(SUM(prod.ValorUnit * i.Quantidade), 2)  IS NULL THEN 'NULO' WHEN FORMAT(SUM(prod.ValorUnit * i.Quantidade),2) > 0 THEN FORMAT(SUM(prod.ValorUnit * i.Quantidade),2)  END FROM tb_pedido AS p INNER JOIN tb_itenspedido AS i ON p.id_pedido = i.Id_PedidoFK INNER JOIN tb_produto AS prod ON prod.id_Produto = i.Id_ProdutoFK WHERE CONVERT(p.Data_Pedido, char(10)) = Convert(CURRENT_DATE(), char(10))", con);
                MySqlDataReader reader = commd.ExecuteReader();          
                    while (reader.Read())
                    {
                        valor = reader.GetString(0);
                    }
                    if(valor == "NULO"){
                    valor = "0,00";
                     }
                
            }
            return valor;
        }
        public string ContarCategorias()
        {
            string valor = "";

            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {
                con.Open();
                MySqlCommand commd = new MySqlCommand("SELECT COUNT(c.idCategoria) FROM tb_categoria AS c", con);
                MySqlDataReader reader = commd.ExecuteReader();
                while (reader.Read())
                {
                    valor = reader.GetString(0);
                }
            }
            return valor;
        }

        public string ContarProdutos()
        {
            string valor = "";

            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {
                con.Open();
                MySqlCommand commd = new MySqlCommand("SELECT COUNT(c.id_Produto) FROM tb_produto AS c", con);
                MySqlDataReader reader = commd.ExecuteReader();
                while (reader.Read())
                {
                    valor = reader.GetString(0);
                }
            }
            return valor;
        }

        public string produtosFim()
        {
            string valor = "";

            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {
                con.Open();
                MySqlCommand commd = new MySqlCommand("SELECT COUNT(p.id_Produto) FROM tb_produto AS p WHERE p.Quantidade <= 4", con);
                MySqlDataReader reader = commd.ExecuteReader();
                while (reader.Read())
                {
                    valor = reader.GetString(0);
                }
            }
            return valor;
        }
    }
}
