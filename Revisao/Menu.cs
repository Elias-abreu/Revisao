﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_divisao_Click(object sender, EventArgs e)
        {
        /* Abrir outro form*/
        /*Outro comentário*/
            Divisao dv = new Divisao();
            dv.ShowDialog();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string sexo = "";
            if(radioButton1.Checked)
            {
                sexo = radioButton1.Text;
            }else if (radioButton2.Checked)
            {
                sexo = radioButton2.Text;
            }
            MessageBox.Show(sexo);
        }
    }
}
