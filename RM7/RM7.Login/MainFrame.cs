using RM1.Framework1.Utilities;
using RM7.Framework.LogHelper;
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
            SubFormDispatcher.Initialize(this);
        }

        private void BindingMenuClickEvent()
        {
            m_userManageMenu.Click += OnMenuClick;
            m_orgManageMenu.Click += OnMenuClick;
            m_userGroupManageMenu.Click += OnMenuClick;
            m_roleManageMenu.Click += OnMenuClick;
            m_authorityMenu.Click += OnMenuClick;
            m_logManageMenu.Click += OnMenuClick;
        }

        private void OnMenuClick(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
                if (menuItem == null)
                {
                    return;
                }
                SubFormDispatcher.SubFormTitle subFormTitle = EnumCommonMethods.GetEnumValue<SubFormDispatcher.SubFormTitle>(menuItem.Text);
                SubFormDispatcher.ShowSubForm(subFormTitle);
            }
            catch (Exception ex)
            {
                LogHelper.Log(ex.Message + "\r\n" + ex.StackTrace);
            }
        }
    }
}
