namespace RSOI_lab1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.rtb_RecieveToken = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ClientSecret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ClientID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 552);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 193);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.rtb_RecieveToken);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tb_ClientSecret);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_ClientID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 167);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Set ClientID and ClientSecret";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtb_RecieveToken
            // 
            this.rtb_RecieveToken.Location = new System.Drawing.Point(6, 62);
            this.rtb_RecieveToken.Name = "rtb_RecieveToken";
            this.rtb_RecieveToken.Size = new System.Drawing.Size(481, 95);
            this.rtb_RecieveToken.TabIndex = 10;
            this.rtb_RecieveToken.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "client_secret: ";
            // 
            // tb_ClientSecret
            // 
            this.tb_ClientSecret.Location = new System.Drawing.Point(85, 36);
            this.tb_ClientSecret.Name = "tb_ClientSecret";
            this.tb_ClientSecret.Size = new System.Drawing.Size(402, 20);
            this.tb_ClientSecret.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "client_id:";
            // 
            // tb_ClientID
            // 
            this.tb_ClientID.Location = new System.Drawing.Point(61, 9);
            this.tb_ClientID.Name = "tb_ClientID";
            this.tb_ClientID.Size = new System.Drawing.Size(402, 20);
            this.tb_ClientID.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 167);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webControl1
            // 
            this.webControl1.Location = new System.Drawing.Point(11, 11);
            this.webControl1.Margin = new System.Windows.Forms.Padding(2);
            this.webControl1.Size = new System.Drawing.Size(748, 524);
            this.webControl1.TabIndex = 7;
            this.webControl1.TargetURLChanged += new Awesomium.Core.UrlEventHandler(this.Awesomium_Windows_Forms_WebControl_TargetURLChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(494, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Запрос не требующий авторизации";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "Запрос требующий авторизации";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 757);
            this.Controls.Add(this.webControl1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtb_RecieveToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ClientSecret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ClientID;
        private System.Windows.Forms.TabPage tabPage2;
        private Awesomium.Windows.Forms.WebControl webControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;

    }
}

