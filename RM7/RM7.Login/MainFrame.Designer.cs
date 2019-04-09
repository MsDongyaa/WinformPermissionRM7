namespace RM7.Login
{
    partial class MainFrame
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_userManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.m_orgManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.m_userGroupManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.m_roleManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.m_authorityMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.m_logManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.m_layoutPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_userManageMenu,
            this.m_orgManageMenu,
            this.m_userGroupManageMenu,
            this.m_roleManageMenu,
            this.m_authorityMenu,
            this.m_logManageMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_userManageMenu
            // 
            this.m_userManageMenu.Name = "m_userManageMenu";
            this.m_userManageMenu.Size = new System.Drawing.Size(68, 21);
            this.m_userManageMenu.Text = "用户管理";
            // 
            // m_orgManageMenu
            // 
            this.m_orgManageMenu.Name = "m_orgManageMenu";
            this.m_orgManageMenu.Size = new System.Drawing.Size(68, 21);
            this.m_orgManageMenu.Text = "组织管理";
            // 
            // m_userGroupManageMenu
            // 
            this.m_userGroupManageMenu.Name = "m_userGroupManageMenu";
            this.m_userGroupManageMenu.Size = new System.Drawing.Size(80, 21);
            this.m_userGroupManageMenu.Text = "用户组管理";
            // 
            // m_roleManageMenu
            // 
            this.m_roleManageMenu.Name = "m_roleManageMenu";
            this.m_roleManageMenu.Size = new System.Drawing.Size(68, 21);
            this.m_roleManageMenu.Text = "角色管理";
            // 
            // m_authorityMenu
            // 
            this.m_authorityMenu.Name = "m_authorityMenu";
            this.m_authorityMenu.Size = new System.Drawing.Size(68, 21);
            this.m_authorityMenu.Text = "权限查看";
            // 
            // m_logManageMenu
            // 
            this.m_logManageMenu.Name = "m_logManageMenu";
            this.m_logManageMenu.Size = new System.Drawing.Size(68, 21);
            this.m_logManageMenu.Text = "日志管理";
            // 
            // m_layoutPanel
            // 
            this.m_layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_layoutPanel.Location = new System.Drawing.Point(0, 25);
            this.m_layoutPanel.Name = "m_layoutPanel";
            this.m_layoutPanel.Size = new System.Drawing.Size(1008, 704);
            this.m_layoutPanel.TabIndex = 2;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.m_layoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainFrame";
            this.ShowIcon = false;
            this.Text = "权限管理系统";
            this.SizeChanged += new System.EventHandler(this.OnMainFrameSizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_userManageMenu;
        private System.Windows.Forms.ToolStripMenuItem m_orgManageMenu;
        private System.Windows.Forms.ToolStripMenuItem m_userGroupManageMenu;
        private System.Windows.Forms.ToolStripMenuItem m_roleManageMenu;
        private System.Windows.Forms.ToolStripMenuItem m_authorityMenu;
        private System.Windows.Forms.ToolStripMenuItem m_logManageMenu;
        private System.Windows.Forms.Panel m_layoutPanel;
    }
}