using MODERN_GUI_2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODERN_GUI_2.Controller
{
    class ControladorProduto
    {
        public bool validarProduto(Produto produtos)
        {
            bool flag = false;
            if (produtos.Cadastrar(produtos))
            {
                MessageBox.Show("Cadastrado com sucesso", "Cadastrado");
                flag = true;
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar", "Cadastro");
                flag = false;

            }
            return flag;
        }
        public bool Atualizar(Produto produtos)
        {
            bool flag = false;
            if (produtos.Atualizar(produtos))
            {
                MessageBox.Show("Atualizado com sucesso", "Atualizar");
                flag = true;
            }
            else
            {
                MessageBox.Show("Erro ao Atualizar", "Atualizar");
                flag = false;

            }
            return flag;
        }
        public DataSet retorna()
        {
            Produto produto = new Produto();
            DataSet dataSet = new DataSet();
            dataSet = produto.retorna();
            return dataSet;
        }
        public DataSet retornaFiltro(string opcao, string texto)
        {
            Produto produto = new Produto();
            DataSet dataSet = new DataSet();
            dataSet = produto.retornaFiltro(opcao, texto);
            return dataSet;
        }
        public void verificaEstoqueInicializacao()
        {
            Produto produto = new Produto();
            List<String> verificacao = produto.VerificarEstoque();
            if(verificacao.Count() >= 1)
            {
                string output = string.Empty;
                foreach (var item in verificacao)
                {
                    output += item + "\n";
                }
                MessageBox.Show("Existem produtos que estão chegando ao fim em seu estoque.  Os produtos são: \n\n" + output, "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public string caixaSemanal()
        {
            Produto produto = new Produto();
            return produto.CaixaSemanal();
        }
        public string contarCategorias()
        {
            Produto produto = new Produto();
            return produto.ContarCategorias();
        }

        public string contarProdutos()
        {
            Produto produto = new Produto();
            return produto.ContarProdutos();
        }

        public string contarProdutosFim()
        {
            Produto produto = new Produto();
            return produto.produtosFim();
        }
        public string caixaDia()
        {
            Produto produto = new Produto();
            return produto.CaixaDia();
        }
    }
}
