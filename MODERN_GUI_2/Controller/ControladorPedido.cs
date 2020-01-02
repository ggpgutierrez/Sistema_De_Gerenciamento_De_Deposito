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
    class ControladorPedido
    {
        public Produto chamarItem(Produto produto)
        {
            Pedido pedido = new Pedido();
            return pedido.inserirProd(produto);

        }
        public DataSet retornaItensPedido(String id)
        {
            Pedido pedido = new Pedido();
            DataSet dataSet = new DataSet();
            dataSet = pedido.retornaItensPedido(id);
            return dataSet;
        }
        public DataSet retorna()
        {
            Pedido pedido = new Pedido();
            DataSet dataSet = new DataSet();
            dataSet = pedido.retorna();
            return dataSet;
        }
        public DataSet retornaTotal(int btn, String data)
        {
            Pedido pedido = new Pedido();
            DataSet dataSet = new DataSet();
            dataSet = pedido.retornaTotalPedidos(btn, data);
            return dataSet;
        }
        public DataSet retornaFiltro(string opcao, string texto)
        {
            Pedido pedido = new Pedido();
            DataSet dataSet = new DataSet();
            dataSet = pedido.retornaFiltro(opcao, texto);
            return dataSet;
        }
        public void finalizarPedido(List<Produto> produtos, List<double> totalProduto, double desconto)
        {
            Pedido pedido = new Pedido();
            pedido.fecharPedido(produtos, totalProduto, desconto);
        }

        public void atualisaStatus(string id, string status)
        {
            Pedido pedido = new Pedido();
            pedido.atualizarSatus(id, status);
        }
    }
}
