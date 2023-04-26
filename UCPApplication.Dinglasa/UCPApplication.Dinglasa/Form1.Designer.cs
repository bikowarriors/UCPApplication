namespace UCPApplication.Dinglasa
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
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opInputOne = new System.Windows.Forms.TextBox();
            this.opInputTwo = new System.Windows.Forms.TextBox();
            this.pOnebtn = new System.Windows.Forms.Button();
            this.pTwoBtn = new System.Windows.Forms.Button();
            this.panelOne1 = new UCPApplication.Dinglasa.PanelOne();
            this.panelTwo1 = new UCPApplication.Dinglasa.PanelTwo();
            this.buttonPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.pTwoBtn);
            this.buttonPanel.Controls.Add(this.pOnebtn);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(200, 406);
            this.buttonPanel.TabIndex = 0;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.opInputTwo);
            this.dataPanel.Controls.Add(this.opInputOne);
            this.dataPanel.Controls.Add(this.label4);
            this.dataPanel.Controls.Add(this.label3);
            this.dataPanel.Controls.Add(this.label1);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataPanel.Location = new System.Drawing.Point(631, 0);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(230, 406);
            this.dataPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Control Panel Application";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Input One:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Input Two:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // opInputOne
            // 
            this.opInputOne.Location = new System.Drawing.Point(28, 110);
            this.opInputOne.Name = "opInputOne";
            this.opInputOne.Size = new System.Drawing.Size(160, 20);
            this.opInputOne.TabIndex = 3;
            this.opInputOne.TextChanged += new System.EventHandler(this.opInputOne_TextChanged);
            // 
            // opInputTwo
            // 
            this.opInputTwo.Location = new System.Drawing.Point(28, 189);
            this.opInputTwo.Name = "opInputTwo";
            this.opInputTwo.Size = new System.Drawing.Size(160, 20);
            this.opInputTwo.TabIndex = 4;
            this.opInputTwo.TextChanged += new System.EventHandler(this.opInputTwo_TextChanged);
            // 
            // pOnebtn
            // 
            this.pOnebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pOnebtn.Location = new System.Drawing.Point(28, 122);
            this.pOnebtn.Name = "pOnebtn";
            this.pOnebtn.Size = new System.Drawing.Size(128, 72);
            this.pOnebtn.TabIndex = 0;
            this.pOnebtn.Text = "Panel 1";
            this.pOnebtn.UseVisualStyleBackColor = true;
            this.pOnebtn.Click += new System.EventHandler(this.pOnebtn_Click);
            // 
            // pTwoBtn
            // 
            this.pTwoBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTwoBtn.Location = new System.Drawing.Point(28, 212);
            this.pTwoBtn.Name = "pTwoBtn";
            this.pTwoBtn.Size = new System.Drawing.Size(128, 72);
            this.pTwoBtn.TabIndex = 1;
            this.pTwoBtn.Text = "Panel 2";
            this.pTwoBtn.UseVisualStyleBackColor = true;
            this.pTwoBtn.Click += new System.EventHandler(this.pTwoBtn_Click);
            // 
            // panelOne1
            // 
            this.panelOne1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panelOne1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelOne1.Location = new System.Drawing.Point(206, 64);
            this.panelOne1.Name = "panelOne1";
            this.panelOne1.Size = new System.Drawing.Size(419, 330);
            this.panelOne1.TabIndex = 4;
            this.panelOne1.Load += new System.EventHandler(this.panelOne1_Load);
            // 
            // panelTwo1
            // 
            this.panelTwo1.BackColor = System.Drawing.SystemColors.Info;
            this.panelTwo1.Location = new System.Drawing.Point(206, 64);
            this.panelTwo1.Name = "panelTwo1";
            this.panelTwo1.Size = new System.Drawing.Size(419, 330);
            this.panelTwo1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 406);
            this.Controls.Add(this.panelOne1);
            this.Controls.Add(this.panelTwo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.buttonPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.buttonPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pTwoBtn;
        private System.Windows.Forms.Button pOnebtn;
        private System.Windows.Forms.TextBox opInputTwo;
        private System.Windows.Forms.TextBox opInputOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private PanelTwo panelTwo1;
        private PanelOne panelOne1;
    }
}

