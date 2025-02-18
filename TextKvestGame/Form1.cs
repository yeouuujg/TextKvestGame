using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TextKvestGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.status = 1;//переменная отвечающая за сюжет
            while (f2.status < 64)
            {
                f2.ShowDialog();//диалог с двумя вариантами ответов
            }
            Close();

        }
    }
}










