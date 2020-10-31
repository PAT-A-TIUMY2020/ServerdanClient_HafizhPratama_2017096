using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_HafizhPratama_2017096
{
	public partial class Form1 : Form
	{
		ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label7.Text = obj.Tambah(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
			label8.Text = obj.Kurang(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
			label9.Text = obj.Kali(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
			label10.Text = obj.Bagi(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
		}
	}
}
