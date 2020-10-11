using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            textBox_index.Text = cp.iCmd.ToString();

        }
        public Assembler_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nameReg= "";
            foreach (var _command in cp.commands)
            {
                
                switch (_command.CommandName)
                {//
                    case "movac":
                        nameReg = "AX";
                        break;
                    case "movm": //взять аргумент, и найти регистр с таким индексом, и извлечь key
                        int i = _command.Argument;
                        nameReg = cp.regs.ElementAt(i).Key;
                        break;
                    case "add":
                        nameReg = "arr[i]";
                        break;
                    case "dec":
                        nameReg = "CX";
                        break;
                    case "jnz":
                        nameReg = "";
                        break;
                }


                var str = new String[] {_command.CommandNumber.ToString(), _command.CommandName, _command.Argument.ToString(),  nameReg};
                ListViewItem item = new ListViewItem(str);

                CommandsList.Items.Add(item);
            }
            SetValues();
            //textBox_PC.Text = cp.commands[1].CommandNumber.ToString();
        }

        private void Registrs_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cp.DoOneCommand();
            SetValues();
            
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
            textBox_SF.Select();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox_ZF.Select();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_AX_TextChanged(object sender, EventArgs e)
        {
            textBox_AX.Select();
        }

        private void textBox_CX_TextChanged(object sender, EventArgs e)
        {
            textBox_CX.Select();

        }

        private void textBox_PC_TextChanged(object sender, EventArgs e)
        {
            textBox_PC.Select();

        }

        private void textBox_CF_TextChanged(object sender, EventArgs e)
        {
            textBox_CF.Select();

        }

        private void textBox_OF_TextChanged(object sender, EventArgs e)
        {
            textBox_OF.Select();

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
