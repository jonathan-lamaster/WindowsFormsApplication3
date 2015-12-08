namespace WindowsFormsApplication3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TestNametextBox = new System.Windows.Forms.TextBox();
            this.InputMessagetextBox = new System.Windows.Forms.TextBox();
            this.ExpectedOutputtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.AddTestbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RunTestButton = new System.Windows.Forms.Button();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tests:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expected Output";
            // 
            // TestNametextBox
            // 
            this.TestNametextBox.Location = new System.Drawing.Point(121, 28);
            this.TestNametextBox.Name = "TestNametextBox";
            this.TestNametextBox.Size = new System.Drawing.Size(100, 20);
            this.TestNametextBox.TabIndex = 4;
            // 
            // InputMessagetextBox
            // 
            this.InputMessagetextBox.Location = new System.Drawing.Point(121, 54);
            this.InputMessagetextBox.Name = "InputMessagetextBox";
            this.InputMessagetextBox.Size = new System.Drawing.Size(100, 20);
            this.InputMessagetextBox.TabIndex = 5;
            // 
            // ExpectedOutputtextBox
            // 
            this.ExpectedOutputtextBox.Location = new System.Drawing.Point(121, 83);
            this.ExpectedOutputtextBox.Name = "ExpectedOutputtextBox";
            this.ExpectedOutputtextBox.Size = new System.Drawing.Size(100, 20);
            this.ExpectedOutputtextBox.TabIndex = 6;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestName,
            this.Description,
            this.InputMessage,
            this.ExpectedOutput,
            this.Status});
            this.dataGridView.Location = new System.Drawing.Point(66, 283);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(959, 205);
            this.dataGridView.TabIndex = 7;
            // 
            // AddTestbutton
            // 
            this.AddTestbutton.Location = new System.Drawing.Point(284, 28);
            this.AddTestbutton.Name = "AddTestbutton";
            this.AddTestbutton.Size = new System.Drawing.Size(83, 38);
            this.AddTestbutton.TabIndex = 8;
            this.AddTestbutton.Text = "Add";
            this.AddTestbutton.UseVisualStyleBackColor = true;
            this.AddTestbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.Location = new System.Drawing.Point(121, 126);
            this.DescriptiontextBox.Multiline = true;
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.Size = new System.Drawing.Size(197, 48);
            this.DescriptiontextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DescriptiontextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TestNametextBox);
            this.groupBox1.Controls.Add(this.AddTestbutton);
            this.groupBox1.Controls.Add(this.InputMessagetextBox);
            this.groupBox1.Controls.Add(this.ExpectedOutputtextBox);
            this.groupBox1.Location = new System.Drawing.Point(66, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 214);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(393, 28);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(83, 38);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RunTestButton
            // 
            this.RunTestButton.Location = new System.Drawing.Point(660, 85);
            this.RunTestButton.Name = "RunTestButton";
            this.RunTestButton.Size = new System.Drawing.Size(98, 69);
            this.RunTestButton.TabIndex = 13;
            this.RunTestButton.Text = "Run Tests";
            this.RunTestButton.UseVisualStyleBackColor = true;
            this.RunTestButton.Click += new System.EventHandler(this.RunTestButton_Click);
            // 
            // TestName
            // 
            this.TestName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TestName.FillWeight = 33.3F;
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            this.TestName.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // InputMessage
            // 
            this.InputMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InputMessage.FillWeight = 11.76471F;
            this.InputMessage.HeaderText = "Input Message";
            this.InputMessage.Name = "InputMessage";
            this.InputMessage.ReadOnly = true;
            this.InputMessage.Width = 225;
            // 
            // ExpectedOutput
            // 
            this.ExpectedOutput.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ExpectedOutput.HeaderText = "Expected Output";
            this.ExpectedOutput.Name = "ExpectedOutput";
            this.ExpectedOutput.ReadOnly = true;
            this.ExpectedOutput.Width = 225;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 535);
            this.Controls.Add(this.RunTestButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "HL7 Automated Testing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TestNametextBox;
        private System.Windows.Forms.TextBox InputMessagetextBox;
        private System.Windows.Forms.TextBox ExpectedOutputtextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button AddTestbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RunTestButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedOutput;
        private System.Windows.Forms.DataGridViewImageColumn Status;
    }
}

