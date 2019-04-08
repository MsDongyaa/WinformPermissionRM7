using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM7.Login
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
            BindingMenuClickEvent();
        }

        private void BindingMenuClickEvent()
        {
            m_userManageMenu.Click += OnUserManageMenuClick;
            m_orgManageMenu.Click += OnOrgManageMenuClick;
            m_userGroupManageMenu.Click += OnUserGroupManageMenuClick;
            m_roleManageMenu.Click += OnRoleManageMenuClick;
            m_authorityMenu.Click += OnAuthorityMenuClick;
            m_logManageMenu.Click += OnLogManageMenuClick;
        }



        private void OnUserManageMenuClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnOrgManageMenuClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnUserGroupManageMenuClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnRoleManageMenuClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnAuthorityMenuClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnLogManageMenuClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
