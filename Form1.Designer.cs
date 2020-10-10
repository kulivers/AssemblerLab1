namespace AssemblerLab1
{
    partial class Assembler_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Registers_Groupbox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CX_label = new System.Windows.Forms.Label();
            this.AX_label = new System.Windows.Forms.Label();
            this.textBox_CX = new System.Windows.Forms.TextBox();
            this.textBox_AX = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_command_bin = new System.Windows.Forms.TextBox();
            this.textBox_command = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Command_label = new System.Windows.Forms.Label();
            this.Flags_Groupbox = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.OF_label = new System.Windows.Forms.Label();
            this.CF_label = new System.Windows.Forms.Label();
            this.SF_label = new System.Windows.Forms.Label();
            this.ZF_label = new System.Windows.Forms.Label();
            this.textBox_OF = new System.Windows.Forms.TextBox();
            this.textBox_CF = new System.Windows.Forms.TextBox();
            this.textBox_SF = new System.Windows.Forms.TextBox();
            this.textBox_ZF = new System.Windows.Forms.TextBox();
            this.CommandsList = new System.Windows.Forms.ListView();
            this.CommandsList_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PC = new System.Windows.Forms.Label();
            this.textBox_PC = new System.Windows.Forms.TextBox();
            this.Registers_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Flags_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Registers_Groupbox
            // 
            this.Registers_Groupbox.AutoSize = true;
            this.Registers_Groupbox.Controls.Add(this.splitContainer1);
            this.Registers_Groupbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Registers_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registers_Groupbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registers_Groupbox.Location = new System.Drawing.Point(504, 23);
            this.Registers_Groupbox.Name = "Registers_Groupbox";
            this.Registers_Groupbox.Size = new System.Drawing.Size(147, 123);
            this.Registers_Groupbox.TabIndex = 0;
            this.Registers_Groupbox.TabStop = false;
            this.Registers_Groupbox.Text = "Registrs";
            this.Registers_Groupbox.Enter += new System.EventHandler(this.Registrs_Enter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 18);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PC);
            this.splitContainer1.Panel1.Controls.Add(this.CX_label);
            this.splitContainer1.Panel1.Controls.Add(this.AX_label);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox_PC);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_CX);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_AX);
            this.splitContainer1.Size = new System.Drawing.Size(141, 102);
            this.splitContainer1.SplitterDistance = 76;
            this.splitContainer1.TabIndex = 0;
            // 
            // CX_label
            // 
            this.CX_label.AutoSize = true;
            this.CX_label.Location = new System.Drawing.Point(2, 47);
            this.CX_label.Name = "CX_label";
            this.CX_label.Size = new System.Drawing.Size(27, 16);
            this.CX_label.TabIndex = 2;
            this.CX_label.Text = "CX";
            this.CX_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // AX_label
            // 
            this.AX_label.AutoSize = true;
            this.AX_label.Location = new System.Drawing.Point(2, 16);
            this.AX_label.Name = "AX_label";
            this.AX_label.Size = new System.Drawing.Size(27, 16);
            this.AX_label.TabIndex = 1;
            this.AX_label.Text = "AX";
            this.AX_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_CX
            // 
            this.textBox_CX.Location = new System.Drawing.Point(3, 41);
            this.textBox_CX.Name = "textBox_CX";
            this.textBox_CX.Size = new System.Drawing.Size(38, 22);
            this.textBox_CX.TabIndex = 1;
            // 
            // textBox_AX
            // 
            this.textBox_AX.Location = new System.Drawing.Point(3, 10);
            this.textBox_AX.Name = "textBox_AX";
            this.textBox_AX.Size = new System.Drawing.Size(38, 22);
            this.textBox_AX.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(243, 231);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(194, 62);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_command_bin
            // 
            this.textBox_command_bin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_command_bin.Location = new System.Drawing.Point(274, 23);
            this.textBox_command_bin.Name = "textBox_command_bin";
            this.textBox_command_bin.Size = new System.Drawing.Size(163, 29);
            this.textBox_command_bin.TabIndex = 2;
            this.textBox_command_bin.Text = "0000_????_????_0000";
            this.textBox_command_bin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_command
            // 
            this.textBox_command.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_command.Location = new System.Drawing.Point(158, 23);
            this.textBox_command.Name = "textBox_command";
            this.textBox_command.Size = new System.Drawing.Size(100, 29);
            this.textBox_command.TabIndex = 3;
            this.textBox_command.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 4;
            // 
            // Command_label
            // 
            this.Command_label.AutoSize = true;
            this.Command_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Command_label.Location = new System.Drawing.Point(42, 26);
            this.Command_label.Name = "Command_label";
            this.Command_label.Size = new System.Drawing.Size(99, 22);
            this.Command_label.TabIndex = 5;
            this.Command_label.Text = "Command:";
            this.Command_label.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Flags_Groupbox
            // 
            this.Flags_Groupbox.AutoSize = true;
            this.Flags_Groupbox.Controls.Add(this.splitContainer2);
            this.Flags_Groupbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Flags_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Flags_Groupbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Flags_Groupbox.Location = new System.Drawing.Point(507, 152);
            this.Flags_Groupbox.Name = "Flags_Groupbox";
            this.Flags_Groupbox.Size = new System.Drawing.Size(147, 144);
            this.Flags_Groupbox.TabIndex = 6;
            this.Flags_Groupbox.TabStop = false;
            this.Flags_Groupbox.Text = "Flags";
            this.Flags_Groupbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 18);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.OF_label);
            this.splitContainer2.Panel1.Controls.Add(this.CF_label);
            this.splitContainer2.Panel1.Controls.Add(this.SF_label);
            this.splitContainer2.Panel1.Controls.Add(this.ZF_label);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.textBox_OF);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_CF);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_SF);
            this.splitContainer2.Panel2.Controls.Add(this.textBox_ZF);
            this.splitContainer2.Size = new System.Drawing.Size(141, 123);
            this.splitContainer2.SplitterDistance = 47;
            this.splitContainer2.TabIndex = 0;
            // 
            // OF_label
            // 
            this.OF_label.AutoSize = true;
            this.OF_label.Location = new System.Drawing.Point(3, 92);
            this.OF_label.Name = "OF_label";
            this.OF_label.Size = new System.Drawing.Size(28, 16);
            this.OF_label.TabIndex = 4;
            this.OF_label.Text = "OF";
            // 
            // CF_label
            // 
            this.CF_label.AutoSize = true;
            this.CF_label.Location = new System.Drawing.Point(2, 67);
            this.CF_label.Name = "CF_label";
            this.CF_label.Size = new System.Drawing.Size(27, 16);
            this.CF_label.TabIndex = 3;
            this.CF_label.Text = "CF";
            this.CF_label.Click += new System.EventHandler(this.label5_Click);
            // 
            // SF_label
            // 
            this.SF_label.AutoSize = true;
            this.SF_label.Location = new System.Drawing.Point(2, 41);
            this.SF_label.Name = "SF_label";
            this.SF_label.Size = new System.Drawing.Size(27, 16);
            this.SF_label.TabIndex = 2;
            this.SF_label.Text = "SF";
            this.SF_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // ZF_label
            // 
            this.ZF_label.AutoSize = true;
            this.ZF_label.Location = new System.Drawing.Point(3, 10);
            this.ZF_label.Name = "ZF_label";
            this.ZF_label.Size = new System.Drawing.Size(26, 16);
            this.ZF_label.TabIndex = 1;
            this.ZF_label.Text = "ZF";
            this.ZF_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_OF
            // 
            this.textBox_OF.Location = new System.Drawing.Point(3, 92);
            this.textBox_OF.Name = "textBox_OF";
            this.textBox_OF.Size = new System.Drawing.Size(38, 22);
            this.textBox_OF.TabIndex = 3;
            // 
            // textBox_CF
            // 
            this.textBox_CF.Location = new System.Drawing.Point(3, 67);
            this.textBox_CF.Name = "textBox_CF";
            this.textBox_CF.Size = new System.Drawing.Size(38, 22);
            this.textBox_CF.TabIndex = 2;
            // 
            // textBox_SF
            // 
            this.textBox_SF.Location = new System.Drawing.Point(3, 41);
            this.textBox_SF.Name = "textBox_SF";
            this.textBox_SF.Size = new System.Drawing.Size(38, 22);
            this.textBox_SF.TabIndex = 1;
            this.textBox_SF.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_ZF
            // 
            this.textBox_ZF.Location = new System.Drawing.Point(3, 10);
            this.textBox_ZF.Name = "textBox_ZF";
            this.textBox_ZF.Size = new System.Drawing.Size(38, 22);
            this.textBox_ZF.TabIndex = 0;
            this.textBox_ZF.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // CommandsList
            // 
            this.CommandsList.HideSelection = false;
            this.CommandsList.Location = new System.Drawing.Point(46, 88);
            this.CommandsList.Name = "CommandsList";
            this.CommandsList.Size = new System.Drawing.Size(122, 205);
            this.CommandsList.TabIndex = 7;
            this.CommandsList.UseCompatibleStateImageBehavior = false;
            this.CommandsList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // CommandsList_label
            // 
            this.CommandsList_label.AutoSize = true;
            this.CommandsList_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommandsList_label.Location = new System.Drawing.Point(43, 72);
            this.CommandsList_label.Name = "CommandsList_label";
            this.CommandsList_label.Size = new System.Drawing.Size(136, 22);
            this.CommandsList_label.TabIndex = 9;
            this.CommandsList_label.Text = "Commands List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // PC
            // 
            this.PC.AutoSize = true;
            this.PC.Location = new System.Drawing.Point(11, 76);
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(28, 16);
            this.PC.TabIndex = 3;
            this.PC.Text = "PC";
            // 
            // textBox_PC
            // 
            this.textBox_PC.Location = new System.Drawing.Point(3, 73);
            this.textBox_PC.Name = "textBox_PC";
            this.textBox_PC.Size = new System.Drawing.Size(38, 22);
            this.textBox_PC.TabIndex = 2;
            // 
            // Assembler_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CommandsList_label);
            this.Controls.Add(this.CommandsList);
            this.Controls.Add(this.Flags_Groupbox);
            this.Controls.Add(this.Command_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_command);
            this.Controls.Add(this.textBox_command_bin);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.Registers_Groupbox);
            this.Name = "Assembler_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Registers_Groupbox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Flags_Groupbox.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Registers_Groupbox;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label CX_label;
        private System.Windows.Forms.Label AX_label;
        private System.Windows.Forms.TextBox textBox_CX;
        private System.Windows.Forms.TextBox textBox_AX;
        private System.Windows.Forms.TextBox textBox_command_bin;
        private System.Windows.Forms.TextBox textBox_command;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Command_label;
        private System.Windows.Forms.GroupBox Flags_Groupbox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label SF_label;
        private System.Windows.Forms.Label ZF_label;
        private System.Windows.Forms.TextBox textBox_SF;
        private System.Windows.Forms.TextBox textBox_ZF;
        private System.Windows.Forms.Label CF_label;
        private System.Windows.Forms.Label OF_label;
        private System.Windows.Forms.TextBox textBox_OF;
        private System.Windows.Forms.TextBox textBox_CF;
        private System.Windows.Forms.ListView CommandsList;
        private System.Windows.Forms.Label CommandsList_label;
        private System.Windows.Forms.Label PC;
        private System.Windows.Forms.TextBox textBox_PC;
        private System.Windows.Forms.Label label2;
    }
}

