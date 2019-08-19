namespace GoogleTranslateWinForms
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Back = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Forward = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Reload = new System.Windows.Forms.ToolStripButton();
            this.toolStripAddressBox1 = new Awesomium.Windows.Forms.ToolStripAddressBox();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.toolStripDropDownButton_Menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.webSessionProvider1 = new Awesomium.Windows.Forms.WebSessionProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Back,
            this.toolStripButton_Forward,
            this.toolStripButton_Reload,
            this.toolStripAddressBox1,
            this.toolStripDropDownButton_Menu,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(685, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Back
            // 
            this.toolStripButton_Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Back.Image = global::GoogleTranslateWinForms.Properties.Resources.iconfinder_arrow_back_outline_216436;
            this.toolStripButton_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Back.Name = "toolStripButton_Back";
            this.toolStripButton_Back.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Back.Text = "Back";
            this.toolStripButton_Back.Click += new System.EventHandler(this.toolStripButton_Back_Click);
            // 
            // toolStripButton_Forward
            // 
            this.toolStripButton_Forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Forward.Image = global::GoogleTranslateWinForms.Properties.Resources.iconfinder_arrow_forward_outline_216441;
            this.toolStripButton_Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Forward.Name = "toolStripButton_Forward";
            this.toolStripButton_Forward.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Forward.Text = "Forward";
            this.toolStripButton_Forward.Click += new System.EventHandler(this.toolStripButton_Forward_Click);
            // 
            // toolStripButton_Reload
            // 
            this.toolStripButton_Reload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Reload.Image = global::GoogleTranslateWinForms.Properties.Resources.iconfinder_sync_126579;
            this.toolStripButton_Reload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Reload.Name = "toolStripButton_Reload";
            this.toolStripButton_Reload.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Reload.Text = "Reload";
            this.toolStripButton_Reload.Click += new System.EventHandler(this.toolStripButton_Reload_Click);
            // 
            // toolStripAddressBox1
            // 
            this.toolStripAddressBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripAddressBox1.Name = "toolStripAddressBox1";
            this.toolStripAddressBox1.Size = new System.Drawing.Size(512, 25);
            this.toolStripAddressBox1.URL = null;
            this.toolStripAddressBox1.WebControl = this.webControl1;
            // 
            // webControl1
            // 
            this.webControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webControl1.Location = new System.Drawing.Point(0, 111);
            this.webControl1.Size = new System.Drawing.Size(685, 258);
            this.webControl1.Source = new System.Uri("https://translate.google.com/", System.UriKind.Absolute);
            this.webControl1.TabIndex = 13;
            // 
            // toolStripDropDownButton_Menu
            // 
            this.toolStripDropDownButton_Menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripDropDownButton_Menu.Image = global::GoogleTranslateWinForms.Properties.Resources.iconfinder_button_switch_vertical_352886;
            this.toolStripDropDownButton_Menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_Menu.Name = "toolStripDropDownButton_Menu";
            this.toolStripDropDownButton_Menu.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton_Menu.Text = "Menu";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.toolStripMenuItem5.Image = global::GoogleTranslateWinForms.Properties.Resources.iconfinder_button_switch_vertical_352886;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "1";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem8.Text = "1";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem9.Text = "2";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem10.Text = "3";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13});
            this.toolStripMenuItem6.Image = global::GoogleTranslateWinForms.Properties.Resources.iconfinder_button_switch_vertical_352886;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem6.Text = "2";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem11.Text = "1";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem12.Text = "2";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem13.Text = "3";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = global::GoogleTranslateWinForms.Properties.Resources.iconfinder_button_switch_vertical_352886;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem7.Text = "3";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripSplitButton1.Image = global::GoogleTranslateWinForms.Properties.Resources.iconfinder_button_switch_vertical_352886;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16});
            this.toolStripMenuItem2.Image = global::GoogleTranslateWinForms.Properties.Resources.iconfinder_button_switch_vertical_352886;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "1";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem14.Text = "1";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem15.Text = "2";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem16.Text = "3";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19});
            this.toolStripMenuItem3.Image = global::GoogleTranslateWinForms.Properties.Resources.iconfinder_button_switch_vertical_352886;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem17.Text = "1";
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem18.Text = "2";
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem19.Text = "3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::GoogleTranslateWinForms.Properties.Resources.iconfinder_button_switch_vertical_352886;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(685, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 61);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 45);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 61);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Text to translation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Translation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Translate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webSessionProvider1
            // 
            this.webSessionProvider1.DataPath = "ApplicationData";
            this.webSessionProvider1.Views.Add(this.webControl1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(424, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "From Language";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "To Language";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(424, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 394);
            this.Controls.Add(this.webControl1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Translate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Back;
        private System.Windows.Forms.ToolStripButton toolStripButton_Forward;
        private System.Windows.Forms.ToolStripButton toolStripButton_Reload;
        private Awesomium.Windows.Forms.ToolStripAddressBox toolStripAddressBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton_Menu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Awesomium.Windows.Forms.WebSessionProvider webSessionProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private Awesomium.Windows.Forms.WebControl webControl1;
    }
}

