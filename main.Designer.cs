
namespace SQLBACKUP
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.conString = new System.Windows.Forms.TextBox();
            this.conUsername = new System.Windows.Forms.TextBox();
            this.conPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.conStatus = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCmdDelete = new System.Windows.Forms.Button();
            this.btnCmdUpdate = new System.Windows.Forms.Button();
            this.btnCmdInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboTables = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.listdb = new System.Windows.Forms.ListBox();
            this.checkAuth = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelJson = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUnsellect = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection String";
            // 
            // conString
            // 
            this.conString.Location = new System.Drawing.Point(163, 27);
            this.conString.Name = "conString";
            this.conString.Size = new System.Drawing.Size(334, 20);
            this.conString.TabIndex = 1;
            this.conString.TextChanged += new System.EventHandler(this.conString_TextChanged);
            // 
            // conUsername
            // 
            this.conUsername.Location = new System.Drawing.Point(113, 91);
            this.conUsername.Name = "conUsername";
            this.conUsername.Size = new System.Drawing.Size(170, 20);
            this.conUsername.TabIndex = 2;
            this.conUsername.TextChanged += new System.EventHandler(this.conUsername_TextChanged);
            // 
            // conPassword
            // 
            this.conPassword.Location = new System.Drawing.Point(113, 114);
            this.conPassword.Name = "conPassword";
            this.conPassword.Size = new System.Drawing.Size(170, 20);
            this.conPassword.TabIndex = 3;
            this.conPassword.TextChanged += new System.EventHandler(this.conPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // conStatus
            // 
            this.conStatus.AutoSize = true;
            this.conStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.conStatus.Location = new System.Drawing.Point(430, 104);
            this.conStatus.Name = "conStatus";
            this.conStatus.Size = new System.Drawing.Size(31, 15);
            this.conStatus.TabIndex = 8;
            this.conStatus.Text = "FAIL";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(6, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Data";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "Generate Script";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnCmdDelete);
            this.groupBox1.Controls.Add(this.btnCmdUpdate);
            this.groupBox1.Controls.Add(this.btnCmdInsert);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnExec);
            this.groupBox1.Controls.Add(this.txtCommand);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboTables);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(530, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 538);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(428, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Create Procodure";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(317, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Select Command";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCmdDelete
            // 
            this.btnCmdDelete.Location = new System.Drawing.Point(755, 12);
            this.btnCmdDelete.Name = "btnCmdDelete";
            this.btnCmdDelete.Size = new System.Drawing.Size(107, 23);
            this.btnCmdDelete.TabIndex = 24;
            this.btnCmdDelete.Text = "Delete Command";
            this.btnCmdDelete.UseVisualStyleBackColor = true;
            this.btnCmdDelete.Click += new System.EventHandler(this.btnCmdDelete_Click);
            // 
            // btnCmdUpdate
            // 
            this.btnCmdUpdate.Location = new System.Drawing.Point(642, 12);
            this.btnCmdUpdate.Name = "btnCmdUpdate";
            this.btnCmdUpdate.Size = new System.Drawing.Size(107, 23);
            this.btnCmdUpdate.TabIndex = 23;
            this.btnCmdUpdate.Text = "Update Command";
            this.btnCmdUpdate.UseVisualStyleBackColor = true;
            this.btnCmdUpdate.Click += new System.EventHandler(this.btnCmdUpdate_Click);
            // 
            // btnCmdInsert
            // 
            this.btnCmdInsert.Location = new System.Drawing.Point(539, 12);
            this.btnCmdInsert.Name = "btnCmdInsert";
            this.btnCmdInsert.Size = new System.Drawing.Size(97, 23);
            this.btnCmdInsert.TabIndex = 16;
            this.btnCmdInsert.Text = "Insert Command";
            this.btnCmdInsert.UseVisualStyleBackColor = true;
            this.btnCmdInsert.Click += new System.EventHandler(this.btnCmdInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(868, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 41);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(868, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 41);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Insert";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(868, 193);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(58, 41);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Command Screen";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(868, 79);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(58, 41);
            this.btnExec.TabIndex = 17;
            this.btnExec.Text = "Exec";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(317, 75);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(545, 54);
            this.txtCommand.TabIndex = 18;
            this.txtCommand.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "TableList";
            // 
            // comboTables
            // 
            this.comboTables.FormattingEnabled = true;
            this.comboTables.Location = new System.Drawing.Point(94, 24);
            this.comboTables.Name = "comboTables";
            this.comboTables.Size = new System.Drawing.Size(210, 21);
            this.comboTables.TabIndex = 15;
            this.comboTables.SelectedIndexChanged += new System.EventHandler(this.comboTables_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 389);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(106, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "Backup";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listdb
            // 
            this.listdb.FormattingEnabled = true;
            this.listdb.Location = new System.Drawing.Point(12, 163);
            this.listdb.Name = "listdb";
            this.listdb.Size = new System.Drawing.Size(223, 342);
            this.listdb.TabIndex = 15;
            this.listdb.SelectedIndexChanged += new System.EventHandler(this.listdb_SelectedIndexChanged);
            // 
            // checkAuth
            // 
            this.checkAuth.AutoSize = true;
            this.checkAuth.Location = new System.Drawing.Point(163, 53);
            this.checkAuth.Name = "checkAuth";
            this.checkAuth.Size = new System.Drawing.Size(141, 17);
            this.checkAuth.TabIndex = 16;
            this.checkAuth.Text = "Windows Authentication";
            this.checkAuth.UseVisualStyleBackColor = true;
            this.checkAuth.CheckedChanged += new System.EventHandler(this.checkAuth_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Connection Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelClass);
            this.groupBox2.Controls.Add(this.labelJson);
            this.groupBox2.Location = new System.Drawing.Point(530, 556);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(932, 165);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // labelJson
            // 
            this.labelJson.AutoSize = true;
            this.labelJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelJson.Location = new System.Drawing.Point(648, 26);
            this.labelJson.Name = "labelJson";
            this.labelJson.Size = new System.Drawing.Size(0, 16);
            this.labelJson.TabIndex = 0;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelClass.Location = new System.Drawing.Point(25, 26);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(0, 16);
            this.labelClass.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(106, 167);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 43);
            this.button6.TabIndex = 18;
            this.button6.Text = "Backup";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(241, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 395);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnUnsellect
            // 
            this.btnUnsellect.Location = new System.Drawing.Point(12, 511);
            this.btnUnsellect.Name = "btnUnsellect";
            this.btnUnsellect.Size = new System.Drawing.Size(223, 39);
            this.btnUnsellect.TabIndex = 20;
            this.btnUnsellect.Text = "Unsellect";
            this.btnUnsellect.UseVisualStyleBackColor = true;
            this.btnUnsellect.Click += new System.EventHandler(this.btnUnsellect_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 114);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "Show Foreign Keys";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 733);
            this.Controls.Add(this.btnUnsellect);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkAuth);
            this.Controls.Add(this.listdb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.conStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.conPassword);
            this.Controls.Add(this.conUsername);
            this.Controls.Add(this.conString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox conString;
        private System.Windows.Forms.TextBox conUsername;
        private System.Windows.Forms.TextBox conPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label conStatus;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTables;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtCommand;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listdb;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCmdDelete;
        private System.Windows.Forms.Button btnCmdUpdate;
        private System.Windows.Forms.Button btnCmdInsert;
        private System.Windows.Forms.CheckBox checkAuth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelJson;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUnsellect;
        private System.Windows.Forms.Button button7;
    }
}

