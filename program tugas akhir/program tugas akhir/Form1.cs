using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program_tugas_akhir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string[] pilihan1 = { "Jagras(common)", "Gastodon(common)", "Rathalos(rare)" };
            string[] pilihan2 = { "Anjanath(rare)", "Rathian(rare)", "Nergigante(super rare)" };
            string[] pilihan3 = { "Xenojiva(super rare)", "Kushala Daora(super rare)", "Teostra and Lunastra(ultra rare)" };
            if (comboBox1.SelectedIndex == 0)
            {
                Random gacha1 = new Random();
                int index = gacha1.Next(pilihan1.Length);
                richTextBox1.Text = $"Selamat !!! Anda Mendapatkan Item {pilihan1[index]}";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Random gacha2 = new Random();
                int index = gacha2.Next(pilihan2.Length);
                richTextBox1.Text = $"Selamat !!! Anda Mendapatkan Item {pilihan2[index]}";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Random gacha3 = new Random();
                int index = gacha3.Next(pilihan3.Length);
                richTextBox1.Text = $"Selamat !!! Anda Mendapatkan Item {pilihan3[index]}";
            }
            
            }
        }
    }


