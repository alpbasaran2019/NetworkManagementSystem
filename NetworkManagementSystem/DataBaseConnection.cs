using Server.MyComponent;
using Server.ProfeBilgi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.AdminLogin
{
    public enum ServerType
    {
        MSSQL = 1,
        ORACLE = 2
    }

    public abstract class DataBaseConnection
    {
        public ServerType ServerTip
        {
            get;
            protected set;
        }
        public string ServerTipKey
        {
            get;
            private set;
        }
        /// <summary>
        /// EDŞ'nin Database Server ile çalışıp çalışmayacağını belirtir
        /// </summary>
        public MyBool SystemUseServerValue;
        public string SystemUseServerKey
        {
            get;
            private set;
        }
        /// <summary>
        /// DataBase'e bağlanabilmek için gerekli kullanıcı adı
        /// </summary>
        public string DB_UserName
        {
            get;
            set;
        }
        public string DB_UserNameKey
        {
            get;
            private set;
        }
        /// <summary>
        /// database'e bağlanabilmek için gerekli şifre
        /// </summary>
        public string DB_Pasword
        {
            get;
            set;
        }
        public string DB_PaswordKey
        {
            get;
            private set;
        }
        /// <summary>
        /// serverın adını tutar.
        /// </summary>
        public string DB_Server
        {
            get;
            set;
        }
        public string DB_ServerKey
        {
            get;
            private set;
        }

        public string DB_OracleServis
        {
            get;
            set;
        }
        public string DB_OracleServisKey
        {
            get;
            private set;
        }

        public string DB_OraclePort
        {
            get;
            set;
        }
        public string DB_OraclePortKey
        {
            get;
            private set;
        }


        /// <summary>
        /// Proje bilgilerinin tutulacağı data base adını tutar.
        /// </summary>
        public string DataBase
        {
            get;
            private set;
        }

        protected abstract void OpenConnection();

        public DataBaseConnection()
        {
            DataBase = "BPROJE";
            DB_Pasword = "";
            DB_PaswordKey = "ANA";
            DB_UserName = "";
            DB_UserNameKey = "ADA";
            SystemUseServerValue = new MyBool();
            SystemUseServerKey = "VERWENDUNGSERVIDOR";
            DB_Server = "";
            DB_ServerKey = "SERVIDOR";
            DB_OracleServis = "";
            DB_OracleServisKey = "ORCSERV";
            DB_OraclePort = "1521";
            DB_OraclePortKey = "ORCPRT";

            ServerTipKey = "SERVERTIP";


          //  SystemUseServerValue.ValueChanged += new ValueChangedEventHandler(Program.m_MainForm.m_STG_GisViewer.SystemUseServerValue_Change);
        }
        public abstract void CreateDb();
        /// <summary>
        /// Ağda Bulunan Serverları listeler
        /// </summary>
        /// <returns>Ağdaki SQL server listesi döner</returns>
        public abstract List<string> ServerName();
        /// <summary>
        /// Siateme Kullanıcı Ekler.
        /// </summary>
        /// <param name="p_UserName">Sisteme giriş için kullanıcı gerekli Kullanıcı Adi</param>
        /// <param name="p_UserPass">Sisteme giriş için kullanıcı gerekli Kullanıcı Şifresi</param>
        /// <param name="p_Name">Kullanıcını Adı</param>
        /// <param name="p_LastName">Kullanıcının Soyadi</param>
        /// <param name="p_IsAdmin">Kullanıcını Yetki durumu true= Admin False=Normal</param>
        public abstract void InsertUser(string p_UserName, string p_UserPass, string p_Name, string p_LastName, bool p_IsAdmin);
        /// <summary>
        /// Sisteme Proje Ekler
        /// </summary>
        /// <param name="p_ProjeName">Proje Adı</param>
        public abstract void InsertProje(string p_ProjeName);
        /// <summary>
        /// Sistemdeki kullanıcıların Projeye Eklenmesini sağlar
        /// </summary>
        /// <param name="p_ProjeID">Proje ID'si</param>
        /// <param name="p_UserIDs">Kullanıcıların ID'si</param>
        public abstract void MatchProje_User(int p_ProjeID, List<int> p_UserIDs);
        /// <summary>
        /// Proje Kullanıcı Ekler olmayanları siler
        /// </summary>
        /// <param name="p_ProjeID">ProjeID</param>
        /// <param name="p_UserID">KullanıcıID</param>
        public abstract void MatchProje_User(int p_ProjeID, int p_UserID);
        /// <summary>
        /// Kullanıcı Bilgilerini Günceller.
        /// </summary>
        /// <param name="p_ID">Güncellenecek Kullanıcının ID'si</param>
        /// <param name="p_UserName">Güncellenecek Kullanıcının Sisteme giriş için kullanıcı gerekli Kullanıcı Adi</param>
        /// <param name="p_UserPass">Güncellenecek Kullanıcının Sisteme giriş için kullanıcı gerekli Kullanıcı Şifresi</param>
        /// <param name="p_Name">Güncellenecek Kullanıcının Kullanıcını Adı</param>
        /// <param name="p_LastName">Güncellenecek Kullanıcının Kullanıcının Soyadi</param>
        /// <param name="p_IsAdmin"Güncellenecek Kullanıcının >Kullanıcını Yetki durumu true= Admin False=Normal</param>
        public abstract void UpdateUser(int p_ID, string p_UserName, string p_UserPass, string p_Name, string p_LastName, bool p_IsAdmin);
        /// <summary>
        /// Seçilen Proje'ye Kullanıcı Eklemek için
        /// </summary>
        /// <param name="p_ProjeID">Seçilen Projenin ID'si</param>
        /// <param name="p_UserIDs">Seçilen Kullanıcların ID'si</param>
        public abstract void DeleteMatchProje_User(int p_ProjeID, List<int> p_UserIDs);
        /// <summary>
        /// Kullanıcıyı ilişkili verileri siler 
        /// </summary>
        /// <param name="p_UserID">Kullanıcı ID</param>
        public abstract void DeleteUser(int p_UserID);
        /// <summary>
        /// Sistemdeki Kullanıcların ID'sini ve Adını getirir.
        /// </summary>
        /// <returns>ID ve Ad Döner</returns>
        public abstract Dictionary<int, string> GetUsers();
        /// <summary>
        /// Sistemdeki Projelerin ID'sini ve Adını Getirir
        /// </summary>
        /// <returns>ID ve Ad Döner</returns>
        public abstract Dictionary<int, string> GetProjects();
        /// <summary>
        /// Projeye Kayıtlı Kıllanıcıları getirir.
        /// </summary>
        /// <param name="p_ProjectID">Projenin ID'si</param>
        /// <returns>Projedeki Kullanıcıların ID'si ve Adını döner</returns>
        public abstract Dictionary<int, string> GetProjectUsers(int p_ProjectID);
        /// <summary>
        /// Kullanıcı için tanımlanan projeleri listeler
        /// </summary>
        /// <param name="p_UserID">Kullanıcının ID'si</param>
        /// <returns>Proje listesi</returns>
        public abstract Dictionary<int, string> GetUSerProjects(int p_UserID);
        /// <summary>
        /// Tanımlı kullanıcının bilgilerini getirir
        /// </summary>
        /// <param name="p_UserID">Kullanıcı ID</param>
        /// <returns>Kullanıcının Bütün Bilgileri</returns>
        public abstract DataTable GetUserInfo(int p_UserID);
        /// <summary>
        /// Sistemdeki giriş için Kullanıcı Adını ve şifresini kontrol eder
        /// </summary>
        /// <param name="p_UserName">kullanıcı Adi</param>
        /// <param name="p_UserPass">Kullanıcı şifresi</param>
        /// <returns></returns>
        public abstract DataTable UserLogin(string p_UserName, string p_UserPass);

        public abstract void DeleteProje(int p_ProjeID);
        protected void ChangeDatabase()
        {
            OpenConnection();
            if (ServerTip == ServerType.MSSQL)
            {
                if (ProjeSabitiBilgileri.DBConnection.State != System.Data.ConnectionState.Open)
                    ProjeSabitiBilgileri.DBConnection.Open();
                if ((ProjeSabitiBilgileri.DBConnection as SqlConnection).Database != DataBase)
                    (ProjeSabitiBilgileri.DBConnection as SqlConnection).ChangeDatabase(DataBase);
            }
            else if (ServerTip == ServerType.ORACLE)
            {
                if (ProjeSabitiBilgileri.DBConnection.State != System.Data.ConnectionState.Open)
                    ProjeSabitiBilgileri.DBConnection.Open();
                //if ((ProjeSabitiBilgileri.DBConnection as OracleConnection).Database != DataBase)
                //    (ProjeSabitiBilgileri.DBConnection as OracleConnection).ChangeDatabase(DataBase);
            }
        }

        public abstract bool DataBaseIsValide(string p_DataBaseName);
    }
}
