namespace TestGame
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.StartBTN = new System.Windows.Forms.Button();
            this.PanelState = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.Color.White;
            this.DrawPanel.Location = new System.Drawing.Point(12, 49);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(600, 600);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseClick);
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            // 
            // StartBTN
            // 
            this.StartBTN.Location = new System.Drawing.Point(12, 12);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(119, 23);
            this.StartBTN.TabIndex = 1;
            this.StartBTN.Text = "Старт";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // PanelState
            // 
            this.PanelState.BackColor = System.Drawing.Color.White;
            this.PanelState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelState.Location = new System.Drawing.Point(573, 3);
            this.PanelState.Name = "PanelState";
            this.PanelState.Size = new System.Drawing.Size(40, 40);
            this.PanelState.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 666);
            this.Controls.Add(this.PanelState);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.DrawPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 705);
            this.MinimumSize = new System.Drawing.Size(640, 705);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Хрестики та нулики";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.Panel PanelState;
    }
}

