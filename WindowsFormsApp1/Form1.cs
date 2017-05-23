using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public static List<string> serhList = new List<string>();

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string msj = string.Format("success create file");
			string fileName = textBox1.Text + ".txt";
			string errorMsj = "eror already file";
			if(button1.BackColor==Color.LimeGreen)
			{
				File.Create(fileName).Close();
				button1.BackColor = Color.Red;
				label3.Text = msj;
				label3.ForeColor = Color.YellowGreen;
			}
			else if (button1.BackColor == Color.Red)
			{
				label3.Text =errorMsj;
				label3.ForeColor = Color.Red;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string fileName = textBox1.Text + ".txt";
			StreamWriter reader = new StreamWriter(fileName,true);
			string nm = string.Format("Serh gonderen:{0} {1}", textBox3.Text, textBox2.Text + ",") + " \n YAzdigi serh: " + textBox4.Text + " ";
			reader.WriteLine();
			comboBox1.Items.Add( textBox3.Text + " " + textBox2.Text);
			serhList.Add(textBox4.Text);
			using (reader)
			{
				for (int i = 0; i < nm.Length; i++)
				{
					reader.Write(nm[i]);
				}
			}
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBox5.Text = serhList[comboBox1.SelectedIndex];
		}
	}
}
