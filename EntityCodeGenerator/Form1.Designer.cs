namespace EntityCodeGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGenerate = new Button();
            txtServer = new TextBox();
            txtDatabase = new TextBox();
            txtTableOrView = new TextBox();
            txtOutputPath = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNameSpace = new TextBox();
            txtCSCode = new TextBox();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(12, 65);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(1172, 74);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate Entity";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtServer
            // 
            txtServer.Location = new Point(212, 36);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(194, 23);
            txtServer.TabIndex = 1;
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(412, 36);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(235, 23);
            txtDatabase.TabIndex = 2;
            // 
            // txtTableOrView
            // 
            txtTableOrView.Location = new Point(653, 36);
            txtTableOrView.Name = "txtTableOrView";
            txtTableOrView.Size = new Size(209, 23);
            txtTableOrView.TabIndex = 3;
            // 
            // txtOutputPath
            // 
            txtOutputPath.Location = new Point(868, 36);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.Size = new Size(315, 23);
            txtOutputPath.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 18);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 5;
            label1.Text = "Server:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 18);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Database:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(653, 18);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "Table\\View:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(868, 18);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Output Path:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 18);
            label5.Name = "label5";
            label5.Size = new Size(146, 15);
            label5.TabIndex = 10;
            label5.Text = "Project Name\\Namespace";
            // 
            // txtNameSpace
            // 
            txtNameSpace.Location = new Point(12, 36);
            txtNameSpace.Name = "txtNameSpace";
            txtNameSpace.Size = new Size(194, 23);
            txtNameSpace.TabIndex = 9;
            // 
            // txtCSCode
            // 
            txtCSCode.Location = new Point(12, 159);
            txtCSCode.Multiline = true;
            txtCSCode.Name = "txtCSCode";
            txtCSCode.ScrollBars = ScrollBars.Both;
            txtCSCode.Size = new Size(1171, 449);
            txtCSCode.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 620);
            Controls.Add(txtCSCode);
            Controls.Add(label5);
            Controls.Add(txtNameSpace);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOutputPath);
            Controls.Add(txtTableOrView);
            Controls.Add(txtDatabase);
            Controls.Add(txtServer);
            Controls.Add(btnGenerate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "C# Entity Code Generator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private TextBox txtServer;
        private TextBox txtDatabase;
        private TextBox txtTableOrView;
        private TextBox txtOutputPath;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNameSpace;
        private TextBox txtCSCode;
    }
}
