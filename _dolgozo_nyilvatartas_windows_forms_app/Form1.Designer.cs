namespace _dolgozo_nyilvatartas_windows_forms_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_Dolgozok = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip_Dolgozo = new System.Windows.Forms.MenuStrip();
            this.modToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Megjelenes = new System.Windows.Forms.Button();
            this.menuStrip_Dolgozo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Dolgozok
            // 
            this.listBox_Dolgozok.FormattingEnabled = true;
            this.listBox_Dolgozok.Location = new System.Drawing.Point(12, 44);
            this.listBox_Dolgozok.Name = "listBox_Dolgozok";
            this.listBox_Dolgozok.Size = new System.Drawing.Size(189, 303);
            this.listBox_Dolgozok.TabIndex = 0;
            this.listBox_Dolgozok.SelectedIndexChanged += new System.EventHandler(this.listBox_Dolgozok_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip_Dolgozo
            // 
            this.menuStrip_Dolgozo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip_Dolgozo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip_Dolgozo.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Dolgozo.Name = "menuStrip_Dolgozo";
            this.menuStrip_Dolgozo.Size = new System.Drawing.Size(217, 24);
            this.menuStrip_Dolgozo.TabIndex = 3;
            this.menuStrip_Dolgozo.Text = "Dolgozo_Nyilvantartas";
            // 
            // modToolStripMenuItem
            // 
            this.modToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.modToolStripMenuItem.Name = "modToolStripMenuItem";
            this.modToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.modToolStripMenuItem.Text = "Mod";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem1});
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem1.Text = "Logout";
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.Yellow;
            this.button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Reset.Location = new System.Drawing.Point(12, 397);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(188, 34);
            this.button_Reset.TabIndex = 4;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            // 
            // button_Megjelenes
            // 
            this.button_Megjelenes.BackColor = System.Drawing.Color.Moccasin;
            this.button_Megjelenes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Megjelenes.Location = new System.Drawing.Point(13, 353);
            this.button_Megjelenes.Name = "button_Megjelenes";
            this.button_Megjelenes.Size = new System.Drawing.Size(187, 38);
            this.button_Megjelenes.TabIndex = 5;
            this.button_Megjelenes.Text = "Megjelenés";
            this.button_Megjelenes.UseVisualStyleBackColor = false;
            this.button_Megjelenes.Click += new System.EventHandler(this.button_Megjelenes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(217, 441);
            this.Controls.Add(this.button_Megjelenes);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.menuStrip_Dolgozo);
            this.Controls.Add(this.listBox_Dolgozok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Dolgozo;
            this.Name = "Form1";
            this.Text = "JSON Database";
            this.menuStrip_Dolgozo.ResumeLayout(false);
            this.menuStrip_Dolgozo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Dolgozok;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip_Dolgozo;
        private System.Windows.Forms.ToolStripMenuItem modToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Megjelenes;
    }
}

