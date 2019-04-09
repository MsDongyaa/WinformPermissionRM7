using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM7.Login
{
    internal class SubFormDispatcher
    {
        private static MainFrame s_mainFrame;

        public static void Initialize(MainFrame mainFrame)
        {
            s_mainFrame = mainFrame;
        }

        public static void ShowSubForm(SubFormTitle subFormTitle)
        {
            if (s_mainFrame == null)
            {
                return;
            }
            switch (subFormTitle)
            {
                case SubFormTitle.UserManage:
                    break;
                case SubFormTitle.OrgManage:
                    break;
                case SubFormTitle.UserGroupManage:
                    break;
                case SubFormTitle.RoleManage:
                    break;
                case SubFormTitle.Authority:
                    break;
                case SubFormTitle.LogManage:
                    break;
                default:
                    break;
            }
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
