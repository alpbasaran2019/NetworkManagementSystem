using Server.AdminLogin;
using Server.MyComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.ProfeBilgi
{
    public class ProjeSabitiBilgileri
    {
        public static List<Language> Language = new List<Language>();
        public static string DefaultProjeFile = "D:\\B INFO\\";
        public static string KeyFileName = System.Windows.Forms.Application.StartupPath + "\\Kisayol.dat";
        public static string BproSystemIni = System.Windows.Forms.Application.StartupPath + "\\bpro.ini";

        public static string DataBaseSection = "DATABASE";
        public static DataBaseConnection ServerOperation = null;
        public static MyBool IsAdmin = new MyComponent.MyBool();
        public static int UserID = -1;
        public static string DBProjeName;
        public static System.Data.Common.DbConnection DBConnection = null;
    }
}
