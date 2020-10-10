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
            textBox_AX.Text = cp.regs["AX"].ToString();
            textBox_CX.Text = cp.regs["CX"].ToString();
            textBox_PC.Text = cp.regs["PC"].ToString();

            textBox_ZF.Text = cp.flags["ZF"].ToString();
            textBox_SF.Text = cp.flags["SF"].ToString();
            textBox_CF.Text = cp.flags["CF"].ToString();
            textBox_OF.Text = cp.flags["OF"].ToString();

            textBox_command.Text = cp.commands[cp.iCmd].CommandName;
            textBox_command_bin.Text = cp.commands[cp.iCmd].BinCommand.ToString();

            CommandsList.Items[cp.iCmd].Selected = true;


        }
        public Assembler_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var _command in cp.commands)
            {
                var str = new String[] { _command.CommandName, _command.Argument.ToString() };
                ListViewItem item = new ListViewItem(str);

                CommandsList.Items.Add(item);
            }

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
