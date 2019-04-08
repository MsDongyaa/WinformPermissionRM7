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
        }

        private void BindingMenuClickEvent()
        {
            m_userManageMenu.Click += OnUserManageMenuClick;

        }

        private void OnUserManageMenuClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
