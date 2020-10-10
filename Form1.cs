using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblerLab1
{
    public partial class Assembler_form : Form
    {
        Cpu cp = new Cpu();

        private void SetValues()
        {
            textBox_AX.Text = Cpu.regs["AX"].ToString();
            textBox_CX.Text = Cpu.regs["CX"].ToString();
            textBox_PC.Text = Cpu.regs["PC"].ToString();

            textBox_ZF.Text = Cpu.flags["ZF"].ToString();
            textBox_SF.Text = Cpu.flags["SF"].ToString();
            textBox_CF.Text = Cpu.flags["CF"].ToString();
            textBox_OF.Text = Cpu.flags["OF"].ToString();

            //textBox_command.Text = 
            //textBox_command_bin.Text = 
        }
        public Assembler_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Registrs_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValues();
            //cp.DoOneCommand();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
