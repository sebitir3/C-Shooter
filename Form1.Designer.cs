namespace Csharpshooter_ST
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchWeaponToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pistolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barret50CalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minigunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superBallLaucherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clippingThroughWallsFastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.title = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.Label();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(784, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.switchWeaponToolStripMenuItem,
            this.speedToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // switchWeaponToolStripMenuItem
            // 
            this.switchWeaponToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pistolToolStripMenuItem,
            this.barret50CalToolStripMenuItem,
            this.minigunToolStripMenuItem,
            this.superBallLaucherToolStripMenuItem});
            this.switchWeaponToolStripMenuItem.Name = "switchWeaponToolStripMenuItem";
            this.switchWeaponToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.switchWeaponToolStripMenuItem.Text = "Switch Weapon";
            // 
            // pistolToolStripMenuItem
            // 
            this.pistolToolStripMenuItem.Name = "pistolToolStripMenuItem";
            this.pistolToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.pistolToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.pistolToolStripMenuItem.Text = "Pistol";
            this.pistolToolStripMenuItem.Click += new System.EventHandler(this.pistolToolStripMenuItem_Click);
            // 
            // barret50CalToolStripMenuItem
            // 
            this.barret50CalToolStripMenuItem.Name = "barret50CalToolStripMenuItem";
            this.barret50CalToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.barret50CalToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.barret50CalToolStripMenuItem.Text = "Barret 50-Cal";
            this.barret50CalToolStripMenuItem.Click += new System.EventHandler(this.barret50CalToolStripMenuItem_Click);
            // 
            // minigunToolStripMenuItem
            // 
            this.minigunToolStripMenuItem.Name = "minigunToolStripMenuItem";
            this.minigunToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.minigunToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.minigunToolStripMenuItem.Text = "Minigun";
            this.minigunToolStripMenuItem.Click += new System.EventHandler(this.minigunToolStripMenuItem_Click);
            // 
            // superBallLaucherToolStripMenuItem
            // 
            this.superBallLaucherToolStripMenuItem.Name = "superBallLaucherToolStripMenuItem";
            this.superBallLaucherToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.superBallLaucherToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.superBallLaucherToolStripMenuItem.Text = "Super Ball Laucher";
            this.superBallLaucherToolStripMenuItem.Click += new System.EventHandler(this.superBallLaucherToolStripMenuItem_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slowToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.fastToolStripMenuItem,
            this.clippingThroughWallsFastToolStripMenuItem});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // slowToolStripMenuItem
            // 
            this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
            this.slowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.slowToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.slowToolStripMenuItem.Text = "Slow";
            this.slowToolStripMenuItem.Click += new System.EventHandler(this.slowToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            this.fastToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.fastToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.fastToolStripMenuItem.Text = "Fast";
            this.fastToolStripMenuItem.Click += new System.EventHandler(this.fastToolStripMenuItem_Click);
            // 
            // clippingThroughWallsFastToolStripMenuItem
            // 
            this.clippingThroughWallsFastToolStripMenuItem.Name = "clippingThroughWallsFastToolStripMenuItem";
            this.clippingThroughWallsFastToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D9)));
            this.clippingThroughWallsFastToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.clippingThroughWallsFastToolStripMenuItem.Text = "Clipping Through Walls Fast";
            this.clippingThroughWallsFastToolStripMenuItem.Click += new System.EventHandler(this.clippingThroughWallsFastToolStripMenuItem_Click);
            // 
            // title
            // 
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Location = new System.Drawing.Point(108, 40);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(581, 204);
            this.title.TabIndex = 2;
            this.title.TabStop = false;
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.Font = new System.Drawing.Font("GENISO", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.SystemColors.Highlight;
            this.play.Location = new System.Drawing.Point(389, 263);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(95, 59);
            this.play.TabIndex = 3;
            this.play.Text = "Play";
            this.play.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.play);
            this.Controls.Add(this.title);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Sharp Shooter";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchWeaponToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pistolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barret50CalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minigunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem superBallLaucherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clippingThroughWallsFastToolStripMenuItem;
        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.Label play;
    }
}

