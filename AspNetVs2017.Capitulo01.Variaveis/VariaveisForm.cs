using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVs2017.Capitulo01.Variaveis
{
    public partial class VariaveisForm : Form
    {
        int _x = 32;
        int _w = 45;
        int _y = 16;
        int _z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritmeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 6;
            int c = 10;
            var d = 13;

            resultadoListBox.Items.Add("a ="+ a);
            resultadoListBox.Items.Add(string.Concat("b =",b));
            resultadoListBox.Items.Add(string.Format("c ={0:C}",c));
            resultadoListBox.Items.Add($"d ={d}");
            resultadoListBox.Items.Add("c * d =" + (c * d));
            resultadoListBox.Items.Add("c / d =" + (c / Convert.ToDecimal(d)));
            resultadoListBox.Items.Add("d % a =" + (d % a));

            // var nascimento = new DateTime(1979, 05, 07);
            // int @int = 10;
            // decimal bimestre1 = 4.44m;
            //  string meuNome = "Elton";
            //TODO:exemplificar a diferença entre class e struct.          
            //a = "42";estaticamente tipada;
            //a = a + "42";fortemente tipada;            
            //não esquecer de inicializar a variável abaixo.                  
            //Clinte cliente = new Cliente():
            //if (b > 3)
            //{

            //}
        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;

            resultadoListBox.Items.Add("x ="+ x);

            //x = x - 3;
            x -= 3;

            resultadoListBox.Items.Add("x =" + x);



        }

        private void incremetaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a;

            a = 5;

            resultadoListBox.Items.Add("exemplo de pré-incremental");
            resultadoListBox.Items.Add("a =" + a);
            resultadoListBox.Items.Add("2+ ++a = " + (2 + ++a));
            resultadoListBox.Items.Add("a =" + a);

            resultadoListBox.Items.Add("------------------");

            a = 5;

            resultadoListBox.Items.Add("exemplo de pós-incremental");
            resultadoListBox.Items.Add("a =" + a);
            resultadoListBox.Items.Add("2+ a++ = " + (2 + a++));
            resultadoListBox.Items.Add("a =" + a);


        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirValoresVariaveis();

            resultadoListBox.Items.Add("w <= x =" + (_w <= _x));
            resultadoListBox.Items.Add("x == z =" + (_x == _z));
            resultadoListBox.Items.Add("x != z =" + (_x != _z));


        }

        private void ExibirValoresVariaveis()
        {
            resultadoListBox.Items.Add("x =" + _x);
            resultadoListBox.Items.Add("w =" + _w);
            resultadoListBox.Items.Add("y =" + _y);
            resultadoListBox.Items.Add("z =" + _z);

            resultadoListBox.Items.Add(new string('-', 50));
        }

        private void logicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirValoresVariaveis();
            //Precedência:
            //1. Negação(!)
            //2. E(&&)
            //3. OU(||)

            resultadoListBox.Items.Add("_w < _x || _y == 16 =" + (_w < _x || _y == 16));
            resultadoListBox.Items.Add("_x == _z && _z!= _x =" + (_x ==_z && _z != _x));
            resultadoListBox.Items.Add("!(_y > _w)=" + (!(_y > _w)));
        }

        private void ternariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ano;

            ano = 2018;

            resultadoListBox.Items.Add($"O ano{ano} é bissexto? {(ano % 4 == 0 ?"Sim" : "Não")}.");

            ano = 2020;

            resultadoListBox.Items.Add($"O ano{ano} é bissexto? {(DateTime.IsLeapYear(ano) ? "Sim" : "Não")}.");

            // var resposta = "";

            // if (DateTime.IsLeapYear(ano))
            // {
            //     resposta = "SIm";
            // }                     

            // else
            // {
             // resposta = "Não";
            //  }

        }
    }
}
