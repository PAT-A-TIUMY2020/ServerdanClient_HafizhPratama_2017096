﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P2_096;


namespace Server_HafizhPratama_2017096
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ServiceHost hostObj = null;
			try
			{
				hostObj = new ServiceHost(typeof(Matematika));
				hostObj.Open();
				label1.Text = "Server ia Ready!!!";
				Console.WriteLine("Server is Ready!!!");
				Console.ReadLine();
				hostObj.Close();
			}
			catch (Exception ex)
			{
				hostObj = null;
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ServiceHost hostObj = null;
			try
			{
				hostObj = new ServiceHost(typeof(Matematika));
				hostObj.Open();
				label3.Text = "Server ia Ready!!!";
				Console.WriteLine("Server is Ready!!!");
				Console.ReadLine();
				hostObj.Close();
			}
			catch (Exception ex)
			{
				hostObj = null;
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			ServiceHost hostObj = null;
			try
			{
				hostObj = new ServiceHost(typeof(Matematika));
				hostObj.Close();

				button2.Enabled = false;
				button1.Enabled = true;
				Console.WriteLine("Server's OFF");
				Console.ReadLine();
				hostObj.Close();
			}
			catch (Exception ex)
			{
				button1.Enabled = false;
				button2.Enabled = true;
				hostObj = null;
				Console.WriteLine(ex.Message);
				Console.ReadLine();
			}
		}
	}
}
