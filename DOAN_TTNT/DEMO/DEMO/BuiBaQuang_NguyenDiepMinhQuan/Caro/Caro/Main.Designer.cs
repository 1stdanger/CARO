namespace Caro
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelps = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.op_comboFirstPlayer = new System.Windows.Forms.ComboBox();
            this.op_comboGameLaw = new System.Windows.Forms.ComboBox();
            this.op_comboPlayerSymbol = new System.Windows.Forms.ComboBox();
            this.op_trackComputerLevel = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.board = new Caro.CaroUI();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.op_trackComputerLevel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.btnHelps});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Image = global::Caro.Properties.Resources.game_pad1;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.newGameToolStripMenuItem.Text = "&New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Image = global::Caro.Properties.Resources.openHS;
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.loadGameToolStripMenuItem.Text = "&Load game...";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnHelps
            // 
            this.btnHelps.Name = "btnHelps";
            this.btnHelps.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.btnHelps.Size = new System.Drawing.Size(61, 24);
            this.btnHelps.Text = "Helps";
            this.btnHelps.Click += new System.EventHandler(this.btnHelps_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // op_comboFirstPlayer
            // 
            this.op_comboFirstPlayer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.op_comboFirstPlayer.FormattingEnabled = true;
            this.op_comboFirstPlayer.Items.AddRange(new object[] {
            "Computer",
            "Player"});
            this.op_comboFirstPlayer.Location = new System.Drawing.Point(-377, -33);
            this.op_comboFirstPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.op_comboFirstPlayer.Name = "op_comboFirstPlayer";
            this.op_comboFirstPlayer.Size = new System.Drawing.Size(109, 24);
            this.op_comboFirstPlayer.TabIndex = 1;
            this.op_comboFirstPlayer.Text = "Player";
            // 
            // op_comboGameLaw
            // 
            this.op_comboGameLaw.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.op_comboGameLaw.Enabled = false;
            this.op_comboGameLaw.FormattingEnabled = true;
            this.op_comboGameLaw.Items.AddRange(new object[] {
            "Gomoku",
            "Caro"});
            this.op_comboGameLaw.Location = new System.Drawing.Point(-377, 15);
            this.op_comboGameLaw.Margin = new System.Windows.Forms.Padding(4);
            this.op_comboGameLaw.Name = "op_comboGameLaw";
            this.op_comboGameLaw.Size = new System.Drawing.Size(109, 24);
            this.op_comboGameLaw.TabIndex = 1;
            this.op_comboGameLaw.Text = "Gomoku";
            // 
            // op_comboPlayerSymbol
            // 
            this.op_comboPlayerSymbol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.op_comboPlayerSymbol.FormattingEnabled = true;
            this.op_comboPlayerSymbol.Items.AddRange(new object[] {
            "X",
            "O"});
            this.op_comboPlayerSymbol.Location = new System.Drawing.Point(-128, -33);
            this.op_comboPlayerSymbol.Margin = new System.Windows.Forms.Padding(4);
            this.op_comboPlayerSymbol.Name = "op_comboPlayerSymbol";
            this.op_comboPlayerSymbol.Size = new System.Drawing.Size(109, 24);
            this.op_comboPlayerSymbol.TabIndex = 1;
            this.op_comboPlayerSymbol.Text = "X";
            // 
            // op_trackComputerLevel
            // 
            this.op_trackComputerLevel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.op_trackComputerLevel.Location = new System.Drawing.Point(-128, 7);
            this.op_trackComputerLevel.Margin = new System.Windows.Forms.Padding(4);
            this.op_trackComputerLevel.Maximum = 20;
            this.op_trackComputerLevel.Minimum = 1;
            this.op_trackComputerLevel.Name = "op_trackComputerLevel";
            this.op_trackComputerLevel.Size = new System.Drawing.Size(111, 56);
            this.op_trackComputerLevel.TabIndex = 3;
            this.op_trackComputerLevel.Value = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.op_trackComputerLevel);
            this.groupBox1.Controls.Add(this.op_comboPlayerSymbol);
            this.groupBox1.Controls.Add(this.op_comboGameLaw);
            this.groupBox1.Controls.Add(this.op_comboFirstPlayer);
            this.groupBox1.Location = new System.Drawing.Point(572, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(27, 25);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Caro game data files|*.caro";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Caro game data files|*.caro";
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.LemonChiffon;
            this.board.Location = new System.Drawing.Point(14, 58);
            this.board.Margin = new System.Windows.Forms.Padding(5);
            this.board.MaximumSize = new System.Drawing.Size(635, 617);
            this.board.MinimumSize = new System.Drawing.Size(635, 617);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(635, 617);
            this.board.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(656, 689);
            this.Controls.Add(this.board);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Caro";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.op_trackComputerLevel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CaroUI board;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnHelps;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox op_comboFirstPlayer;
        private System.Windows.Forms.ComboBox op_comboGameLaw;
        private System.Windows.Forms.ComboBox op_comboPlayerSymbol;
        private System.Windows.Forms.TrackBar op_trackComputerLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

    }
}

