using RM7.UserManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM7.Login
{
    internal class SubFormDispatcher
    {
        private static MainFrame s_mainForm;
        private static Panel s_layoutPanel;
        private static Dictionary<SubFormTitle, Form> s_subFormCache;

        public static void Initialize(MainFrame mainFrame, Panel layoutPanel)
        {
            s_mainForm = mainFrame;
            s_layoutPanel = layoutPanel;
            s_subFormCache = new Dictionary<SubFormTitle, Form>();
        }

        public static void ShowSubForm(SubFormTitle subFormTitle)
        {
            if (s_mainForm == null)
            {
                return;
            }
            Form subForm;
            if (s_subFormCache.ContainsKey(subFormTitle))
            {
                subForm = s_subFormCache[subFormTitle];
            }
            else
            {
                subForm = CreateSubForm(subFormTitle);
            }
            if (subForm != null)
            {
                InitSubForm(subForm);
                s_subFormCache[subFormTitle] = subForm;
                subForm.Show();
            }
        }

        private static Form CreateSubForm(SubFormTitle subFormTitle)
        {
            switch (subFormTitle)
            {
                case SubFormTitle.UserManage:
                    return new UserManageForm();
                case SubFormTitle.OrgManage:
                    return new Form();
                case SubFormTitle.UserGroupManage:
                    return new Form();
                case SubFormTitle.RoleManage:
                    return new Form();
                case SubFormTitle.Authority:
                    return new Form();
                case SubFormTitle.LogManage:
                    return new Form();
                default:
                    return null;
            }
        }

        private static void InitSubForm(Form subForm)
        {
            s_layoutPanel.Controls.Clear();
            subForm.WindowState = FormWindowState.Maximized;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.MdiParent = s_mainForm;
            subForm.Parent = s_layoutPanel;
        }

        public enum SubFormTitle
        {
            [Description("用户管理")]
            UserManage = 0,
            [Description("组织管理")]
            OrgManage,
            [Description("用户组管理")]
            UserGroupManage,
            [Description("角色管理")]
            RoleManage,
            [Description("权限查看")]
            Authority,
            [Description("日志管理")]
            LogManage
        }
    }
}
