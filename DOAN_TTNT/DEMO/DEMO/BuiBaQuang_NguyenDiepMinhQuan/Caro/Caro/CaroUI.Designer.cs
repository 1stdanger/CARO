namespace Caro
{
    partial class CaroUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CaroStatus = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CaroTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CaroMessage = new System.Windows.Forms.ToolStripLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CaroStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CaroStatus
            // 
            this.CaroStatus.AutoSize = false;
            this.CaroStatus.BackColor = System.Drawing.Color.Lavender;
            this.CaroStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CaroStatus.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.CaroStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CaroStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.CaroTime,
            this.toolStripSeparator1,
            this.CaroMessage});
            this.CaroStatus.Location = new System.Drawing.Point(0, 0);
            this.CaroStatus.Name = "CaroStatus";
            this.CaroStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CaroStatus.Size = new System.Drawing.Size(480, 31);
            this.CaroStatus.TabIndex = 1;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // CaroTime
            // 
            this.CaroTime.Name = "CaroTime";
            this.CaroTime.Size = new System.Drawing.Size(52, 28);
            this.CaroTime.Text = "00:00";
            this.CaroTime.ToolTipText = "Played time";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // CaroMessage
            // 
            this.CaroMessage.Name = "CaroMessage";
            this.CaroMessage.Size = new System.Drawing.Size(75, 28);
            this.CaroMessage.Text = "Message";
            this.CaroMessage.ToolTipText = "Message";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CaroBoardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CaroStatus);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CaroBoardUI";
            this.Size = new System.Drawing.Size(480, 443);
            this.CaroStatus.ResumeLayout(false);
            this.CaroStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip CaroStatus;
        private System.Windows.Forms.ToolStripLabel CaroTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripLabel CaroMessage;

    }
}
