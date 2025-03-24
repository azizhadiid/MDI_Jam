namespace Jam.GUI
{
    partial class FormTimer
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
            this.labelH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelH.Location = new System.Drawing.Point(24, 86);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(203, 156);
            this.labelH.TabIndex = 1;
            this.labelH.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(201, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 156);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelM.Location = new System.Drawing.Point(263, 86);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(203, 156);
            this.labelM.TabIndex = 3;
            this.labelM.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(449, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 156);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelS.Location = new System.Drawing.Point(527, 86);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(203, 156);
            this.labelS.TabIndex = 5;
            this.labelS.Text = "00";
            // 
            // textBoxH
            // 
            this.textBoxH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxH.Location = new System.Drawing.Point(127, 312);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 68);
            this.textBoxH.TabIndex = 6;
            // 
            // textBoxM
            // 
            this.textBoxM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxM.Location = new System.Drawing.Point(307, 312);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(100, 68);
            this.textBoxM.TabIndex = 7;
            // 
            // textBoxS
            // 
            this.textBoxS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxS.Location = new System.Drawing.Point(506, 312);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(100, 68);
            this.textBoxS.TabIndex = 8;
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.Cyan;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_reset.Font = new System.Drawing.Font("Microsoft YaHei", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_reset.Location = new System.Drawing.Point(540, 473);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(160, 60);
            this.button_reset.TabIndex = 11;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_stop
            // 
            this.button_stop.BackColor = System.Drawing.Color.Red;
            this.button_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_stop.Font = new System.Drawing.Font("Microsoft YaHei", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_stop.Location = new System.Drawing.Point(307, 473);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(160, 60);
            this.button_stop.TabIndex = 10;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = false;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.Lime;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start.Font = new System.Drawing.Font("Microsoft YaHei", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_start.Location = new System.Drawing.Point(77, 473);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(160, 60);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // FormTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelH);
            this.Name = "FormTimer";
            this.Text = "FormTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer;
    }
}