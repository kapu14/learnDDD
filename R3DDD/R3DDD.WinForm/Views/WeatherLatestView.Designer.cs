namespace R3DDD.WinForm.Views
{
    partial class WeatherLatestView
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
            this.AreaIdTextbox = new System.Windows.Forms.TextBox();
            this.AreaNameTextbox = new System.Windows.Forms.TextBox();
            this.DataDateTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConditionTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.temperatureTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "エリア番号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "エリア名";
            // 
            // AreaIdTextbox
            // 
            this.AreaIdTextbox.Location = new System.Drawing.Point(90, 44);
            this.AreaIdTextbox.Name = "AreaIdTextbox";
            this.AreaIdTextbox.Size = new System.Drawing.Size(154, 19);
            this.AreaIdTextbox.TabIndex = 2;
            // 
            // AreaNameTextbox
            // 
            this.AreaNameTextbox.Location = new System.Drawing.Point(90, 69);
            this.AreaNameTextbox.Name = "AreaNameTextbox";
            this.AreaNameTextbox.Size = new System.Drawing.Size(154, 19);
            this.AreaNameTextbox.TabIndex = 3;
            // 
            // DataDateTextbox
            // 
            this.DataDateTextbox.Location = new System.Drawing.Point(90, 94);
            this.DataDateTextbox.Name = "DataDateTextbox";
            this.DataDateTextbox.Size = new System.Drawing.Size(154, 19);
            this.DataDateTextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "日時";
            // 
            // ConditionTextbox
            // 
            this.ConditionTextbox.Location = new System.Drawing.Point(90, 119);
            this.ConditionTextbox.Name = "ConditionTextbox";
            this.ConditionTextbox.Size = new System.Drawing.Size(154, 19);
            this.ConditionTextbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "状態";
            // 
            // temperatureTextbox
            // 
            this.temperatureTextbox.Location = new System.Drawing.Point(90, 144);
            this.temperatureTextbox.Name = "temperatureTextbox";
            this.temperatureTextbox.Size = new System.Drawing.Size(154, 19);
            this.temperatureTextbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "温度";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(15, 202);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(253, 23);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 245);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(280, 23);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(92, 18);
            this.toolStripStatusLabel1.Text = "デバッグモード";
            // 
            // WeatherLatestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 268);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.temperatureTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConditionTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DataDateTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AreaNameTextbox);
            this.Controls.Add(this.AreaIdTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeatherLatestView";
            this.Text = "WeatherLatestView";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AreaIdTextbox;
        private System.Windows.Forms.TextBox AreaNameTextbox;
        private System.Windows.Forms.TextBox DataDateTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConditionTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox temperatureTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}