using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troco
{
    public partial class FrmST : Form
    {
        public FrmST()
        {
            InitializeComponent();
        }
        double preco = 0.0;
        
        private void btnCalcula_Click(object sender, EventArgs e)
        {
            preco = Convert.ToDouble(txtPreco.Text);

            //Calcula a quantidade de notas de R$100
            int quantia = 0; 
            while(preco >= 100)
            {                               
                preco = preco - 100;
                quantia = quantia + 1;                
            }
            txt100.Text = Convert.ToString(quantia);

            //Calcula a quantidade de notas de R$50
            quantia = 0;
            while(preco >= 50)
            {
                preco = preco - 50;
               quantia = quantia + 1;
            }
            txt50.Text = Convert.ToString(quantia);

            //Calcula a quantidade de notas de R$20
            quantia = 0;
            while(preco >= 20)
            {
                preco = preco - 20;
                quantia = quantia + 1;
            }
            txt20.Text = Convert.ToString(quantia);

            //Calcula a quantidade de notas de R$10
            quantia = 0;
            while(preco >= 10)
            {
                preco = preco -  10;
                quantia = quantia + 1;
            }
            txt10.Text = Convert.ToString(quantia);

            //Calcula a quantidade de notas de R$5
            quantia = 0;
            while (preco >= 5)
            {
                preco = preco -  5;
                quantia = quantia + 1;
            }
            txt5.Text = Convert.ToString(quantia);

            //Calcula a quantidade de notas de R$2
            quantia = 0;
            while (preco >= 2)
            {
                preco = preco -  2;
                quantia = quantia + 1;
            }
            txt2.Text = Convert.ToString(quantia);

            //Calcula a quantidade de moedas de R$1
            quantia = 0;
            while (preco >= 1)
            {
                preco = preco -  1;
                quantia = quantia + 1;
            }
            txt1.Text = Convert.ToString(quantia);

            //Calcula a quantidade de moedas de R$0,50
            quantia = 0;
            while (preco >= 0.50)
            {
                preco = preco -  0.50;
                quantia = quantia + 1;
            }
            txt50C.Text = Convert.ToString(quantia);

            //Calcula a quantidade de moedas de R$0,25
            quantia = 0;
            while (preco >= 0.25)
            {
                preco = preco -  0.25;
                quantia = quantia + 1;
            }
            txt25C.Text = Convert.ToString(quantia);

            //Calcula a quantidade de moedas de R$0,10
            quantia = 0;
            while (preco >= 0.10)
            {
                preco = preco -  0.10;
                quantia = quantia + 1;
            }
            txt10C.Text = Convert.ToString(quantia);

            //Calcula a quantidade de moedas de R$0,05
            quantia = 0;
            while (preco >= 0.05)
            {
                preco = preco -  0.05;
                quantia = quantia + 1;
            }
            txt5C.Text = Convert.ToString(quantia);

            //Calcula a quantidade de moedas de R$0,01
            quantia = 0;
            while (preco >= 0.01)
            {
                preco = preco -  0.01;
                quantia = quantia + 1;
            }
            txt1C.Text = Convert.ToString(quantia);


        }

        private void txtLimpar_Click(object sender, EventArgs e)
        {
            //Limpar TextBox
            txtPreco.Text = "";
            txt100.Text = "";
            txt50.Text = "";
            txt20.Text = "";
            txt10.Text = "";
            txt5.Text = "";
            txt2.Text = "";
            txt1.Text = "";
            txt50C.Text = "";
            txt25C.Text = "";
            txt10C.Text = "";
            txt5C.Text = "";
            txt1C.Text = "";

        }
    }
}
