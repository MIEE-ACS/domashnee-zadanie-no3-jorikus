using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		static string Cezar(string input_string, int sm)
		{
			string alp_lower = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
			string alp_upper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
			var list = new List<char>();
			for (int i = 0; i < input_string.Length; i++)
			{
				char temp = input_string[i];
				if (char.IsLetter(temp))
				{
					if (char.IsLower(temp))
					{
						for (int j = 0; j < 32; j++)
						{
							if (alp_lower[j] == temp)
							{
								int index = j + sm;
								list.Add(alp_lower[index]);
								break;
							}
						}
					}
					else if (char.IsUpper(temp))
					{
						for (int j = 0; j < 32; j++)
						{
							if (alp_upper[j] == temp)
							{
								int index = j + sm;
								list.Add(alp_upper[index]);
								break;
							}
						}
					}
				}
				else
				{
					list.Add(temp);
				}
			}
			string result = String.Join("", list.ToArray());
			return result;
		}
		private void button1_Click(object sender, EventArgs e)
        {
            string inp_str = textBox1.Text;
			int sm = comboBox1.SelectedIndex + 1;
			string out_str = Cezar(inp_str, sm);
			textBox2.Text = out_str;
        }
    }
}
