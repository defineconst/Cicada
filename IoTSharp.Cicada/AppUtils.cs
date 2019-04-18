
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTSharp.Cicada
{
    public static class AppUtils
    {
        public static T ShowMdiChildren<T>(this Form @this)
             where T : Form
        {
            return ShowMdiChildren<T>(@this,"",false,null);
        }
        public static T ShowMdiChildren<T>(this Form @this, Action<T> func)
          where T : Form
        {
            return ShowMdiChildren<T>(@this, null, false, func);
        }
            public static T ShowMdiChildren<T>(this Form @this, string title)
        where T : Form
        {
            return ShowMdiChildren<T>(@this, title, false,null);
        }
        public static T ShowMdiChildren<T>(this Form @this, bool newone)
        where T : Form
        {
            return ShowMdiChildren<T>(@this, null, true,null);
        }
        public static T ShowMdiChildren<T>(this Form owner, string title, bool newone, Action<T> func)
        where T : Form
        {
            GC.Collect();
            T f = default(T);
            if (newone == false)
            {
                var frm = from n in owner.MdiChildren
                          where n.GetType() == typeof(T)
                          select n;
                f = frm.SingleOrDefault() as T;
            }
            if (f == null)
            {
                f = Activator.CreateInstance<T>();
                f.MdiParent = owner;
            }
            func?.Invoke(f);
            f.Show();
            f.Activate();
            return f;
        }
        public static void ShowFileByExplorer(string filename)
        {
            try
            {
                FileInfo fi = new FileInfo(filename);
                string args = string.Format("/select,\"{0}\"", fi.FullName);
                System.Diagnostics.Process.Start("Explorer.exe", args);
            }
            catch (Exception)
            {


            }
        }

        #region 程序集特性访问器

        public static string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public static string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public static string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
