namespace PluralSightDownloader
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
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJson = new System.Windows.Forms.TextBox();
            this.btnParseJson = new System.Windows.Forms.Button();
            this.lbParsedJson = new System.Windows.Forms.Label();
            this.btnCheckJson = new System.Windows.Forms.Button();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(8, 12);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(680, 20);
            this.tbAddress.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(691, 10);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(50, 21);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(664, 493);
            this.toolStripContainer1.Location = new System.Drawing.Point(8, 39);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(664, 518);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 19);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(677, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 286);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 397);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // tbJson
            // 
            this.tbJson.Location = new System.Drawing.Point(856, 39);
            this.tbJson.Margin = new System.Windows.Forms.Padding(2);
            this.tbJson.Multiline = true;
            this.tbJson.Name = "tbJson";
            this.tbJson.Size = new System.Drawing.Size(307, 286);
            this.tbJson.TabIndex = 7;
            // 
            // btnParseJson
            // 
            this.btnParseJson.Location = new System.Drawing.Point(856, 333);
            this.btnParseJson.Margin = new System.Windows.Forms.Padding(2);
            this.btnParseJson.Name = "btnParseJson";
            this.btnParseJson.Size = new System.Drawing.Size(305, 21);
            this.btnParseJson.TabIndex = 8;
            this.btnParseJson.Text = "Parse";
            this.btnParseJson.UseVisualStyleBackColor = true;
            this.btnParseJson.Click += new System.EventHandler(this.btnParseJson_Click);
            // 
            // lbParsedJson
            // 
            this.lbParsedJson.AutoSize = true;
            this.lbParsedJson.Location = new System.Drawing.Point(853, 410);
            this.lbParsedJson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbParsedJson.Name = "lbParsedJson";
            this.lbParsedJson.Size = new System.Drawing.Size(35, 13);
            this.lbParsedJson.TabIndex = 9;
            this.lbParsedJson.Text = "label2";
            // 
            // btnCheckJson
            // 
            this.btnCheckJson.Location = new System.Drawing.Point(856, 358);
            this.btnCheckJson.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckJson.Name = "btnCheckJson";
            this.btnCheckJson.Size = new System.Drawing.Size(305, 21);
            this.btnCheckJson.TabIndex = 8;
            this.btnCheckJson.Text = "check";
            this.btnCheckJson.UseVisualStyleBackColor = true;
            this.btnCheckJson.Click += new System.EventHandler(this.btnCheckJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 565);
            this.Controls.Add(this.lbParsedJson);
            this.Controls.Add(this.btnCheckJson);
            this.Controls.Add(this.btnParseJson);
            this.Controls.Add(this.tbJson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbAddress);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnGo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbJson;
        private System.Windows.Forms.Button btnParseJson;
        private System.Windows.Forms.Label lbParsedJson;
        private System.Windows.Forms.Button btnCheckJson;

    }
}

