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
    class ControladorCategoria
    {
        public bool validarCategoria(Categorias categorias)
        {
            bool flag = false;
            if (categorias.Cadastrar(categorias))
            {
                MessageBox.Show("Cadastrado com sucesso", "Cadastrado");
                flag = true;
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar","Cadastro");
                flag = false;

            }
            return flag;
        }
        public bool atualizarCategoria(Categorias categorias)
        {
            bool flag = false;
            if (categorias.Atualizar(categorias))
            {
                MessageBox.Show("Atualizado com sucesso", "Atualizado");
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
            Categorias categorias = new Categorias();
            DataSet dataSet = new DataSet();
            dataSet = categorias.retorna();
            return dataSet;
        }
        public DataTable preencheComboBox()
        {
            Categorias categorias = new Categorias();
            return categorias.popularComboBox();
        }


    }
}
