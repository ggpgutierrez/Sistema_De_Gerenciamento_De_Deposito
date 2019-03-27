using MODERN_GUI_2.Auxiliar;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODERN_GUI_2.Model
{
    class Pedido
    {
        public int idPedido { get; set; }
        public int idUsuarioFK { get; set; }
        public int Data_Pedido { get; set; }
        Connection connection = new Connection();

        public Produto inserirProd(Produto produto)
        {

            using (var con = connection.Conectar())
            {

                con.Open();

                MySqlCommand commd = new MySqlCommand("SELECT p.id_Produto AS ID, p.NomeProduto AS Produto, p.ValorUnit AS Valor, c.NomeCategoria AS Tipo,p.UnidadeMedida AS 'Unidade de Medida', p.DescricaoProduto AS 'Detalhamento', p.Quantidade AS 'Quantidade'" +
                    "FROM tb_produto AS p INNER JOIN tb_categoria AS c ON p.TipoProdutoFK = c.idCategoria WHERE p.id_Produto = @id_Produto", con);
                commd.Parameters.AddWithValue("@id_Produto", produto.idProduto);

                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = commd;
                DataTable objDataTable = new DataTable();

                ad.Fill(objDataTable);

                Produto prd = new Produto();
                //Percorrer as linhas do datatable para adicionar na lista 
                foreach (DataRow dataRow in objDataTable.Rows)
                {
                    Produto produto1 = new Produto();
                    //Adiciona na lista Especificando a clouna 
                    produto1.idProduto = dataRow["ID"].ToString();
                    produto1.Qtd = dataRow["Quantidade"].ToString();
                    produto1.nomeProduto = dataRow["Produto"].ToString();
                    produto1.ValorUnit = dataRow["Valor"].ToString();
                    produto1.UnidadeMedida = dataRow["Unidade de Medida"].ToString();
                    prd.idProduto = produto1.idProduto;
                    prd.Qtd = produto1.Qtd;
                    prd.nomeProduto = produto1.nomeProduto;
                    prd.ValorUnit = produto1.ValorUnit;
                    prd.UnidadeMedida = produto1.UnidadeMedida;



                }

                return prd;
            }
        }

        public void atualizarSatus(string id, string status)
        {
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {

                con.Open();

                MySqlCommand commd = new MySqlCommand("UPDATE `tb_pedido` SET `Status` = ? WHERE `id_pedido` = ?", con);
                commd.Parameters.AddWithValue("@Status", status);
                commd.Parameters.AddWithValue("@id_pedido", id);
                try
                {
                    commd.ExecuteNonQuery();
                    MessageBox.Show("Atualizado com Sucesso!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro" + e);

                }
            }
        }
        public DataSet retornaItensPedido(string id)
        {
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {
                MySqlCommand commd = new MySqlCommand("");
                con.Open();
             
                    commd = new MySqlCommand(
                            @"SELECT c.id_Produto AS 'Id Produto', c.ValorUnit AS 'Valor', i.Quantidade AS Qtd, (i.Quantidade * c.ValorUnit) AS 'Valor Final'     
                            FROM tb_pedido AS p
                            INNER JOIN tb_itenspedido AS i
                            ON i.Id_PedidoFK = p.id_pedido
                            INNER JOIN tb_produto AS c
                            ON c.id_Produto = i.Id_ProdutoFK
                            WHERE p.id_pedido ="+ id +" GROUP BY i.Id_ProdutoFK", con);
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
                if (opcao == "Hoje")
                {
                    commd = new MySqlCommand(
                            @"SELECT p.Id_Pedido AS ID, DATE_FORMAT(STR_TO_DATE(Data_Pedido, '%Y-%m-%d'), '%d/%m/%Y') AS Data, SUM((i.Quantidade * c.ValorUnit)) AS Total, p.Status  
                            FROM tb_pedido AS p
                            INNER JOIN tb_itenspedido AS i
                            ON i.Id_PedidoFK = p.id_pedido
                            INNER JOIN tb_produto AS c
                             ON c.id_Produto = i.Id_ProdutoFK
                             WHERE p.Data_Pedido LIKE '%" + texto +"%' GROUP BY p.id_pedido" , con);
                   
                }
                else
                {
                    commd = new MySqlCommand(
                            @"SELECT p.Id_Pedido AS ID, DATE_FORMAT(STR_TO_DATE(Data_Pedido, '%Y-%m-%d'), '%d/%m/%Y') AS Data, SUM((i.Quantidade * c.ValorUnit)) AS Total, p.Status
                            FROM tb_pedido AS p
                            INNER JOIN tb_itenspedido AS i
                            ON i.Id_PedidoFK = p.id_pedido
                            INNER JOIN tb_produto AS c
                             ON c.id_Produto = i.Id_ProdutoFK
                             WHERE DATE_FORMAT(STR_TO_DATE(Data_Pedido, '%Y-%m-%d'), '%d/%m/%Y') LIKE '%" + texto + "%' GROUP BY p.id_pedido", con);
                }
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = commd;
                DataSet dataSet = new DataSet();
                ad.Fill(dataSet);

                return dataSet;
            }

        }
        public DataSet retorna()
        {
            Connection connection = new Connection();
            using (var con = connection.Conectar())
            {

                con.Open();
                MySqlCommand commd = new MySqlCommand(@"SELECT p.Id_Pedido AS ID, DATE_FORMAT(STR_TO_DATE(Data_Pedido, '%Y-%m-%d'), '%d/%m/%Y') AS Data, SUM((i.Quantidade * c.ValorUnit)) AS Total, p.Status  FROM tb_pedido AS p
                INNER JOIN tb_itenspedido AS i
                ON i.Id_PedidoFK = p.id_pedido
                INNER JOIN tb_produto AS c
                ON c.id_Produto = i.Id_ProdutoFK
                GROUP BY p.id_pedido", con);
                MySqlDataAdapter ad = new MySqlDataAdapter();
                ad.SelectCommand = commd;
                DataSet dataSet = new DataSet();
                ad.Fill(dataSet);

                return dataSet;
            }
        }

        public void fecharPedido(List<Produto> produtos)
        {
            bool flag = true;

            using (var con = connection.Conectar())
            {

                con.Open();
                MySqlCommand commd = new MySqlCommand("INSERT INTO tb_pedido (`id_pedido`) VALUES(NULL); SELECT LAST_INSERT_ID() FROM tb_pedido;", con);
                String resultado = "";
                try
                {
                    MySqlDataReader reader = commd.ExecuteReader();
                    while (reader.Read())
                    {
                        resultado = (reader.GetString(0));
                    }

                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro" + e);
                    flag = false;

                }
                try
                {
                    using (var con2 = connection.Conectar())
                    {
                        con2.Open();
                        for (int i = 0; i <= produtos.Count(); i++)
                        {
                            MySqlCommand commd2 = new MySqlCommand("INSERT INTO `tb_itenspedido`(`Id_PedidoFK`, `Id_ProdutoFK`, `Quantidade`) " +
                                "VALUES(" + resultado + "," + produtos[i].idProduto + "," + '"' + produtos[i].Qtd + '"' + ");", con2);

                            int fl = commd2.ExecuteNonQuery();
                            flag = Convert.ToBoolean(fl);
                            
                        }
                    }
                }
                catch (Exception r)
                {
                    Console.WriteLine("Erro" + r);
                }

            }
            if (flag)
            {
                MessageBox.Show("Pedido Concluido");
            } else{
                MessageBox.Show("Erro ao tentar finalizar pedido");
            }
        }
    }
}

    

