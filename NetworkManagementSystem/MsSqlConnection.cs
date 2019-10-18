using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Windows.Forms;
using Server.ProfeBilgi;

namespace Server.AdminLogin
{
    public class MsSqlConnection : DataBaseConnection
    {
        Microsoft.SqlServer.Management.Smo.Server l_Svr;
        public MsSqlConnection()
            : base()
        {
            ServerTip = ServerType.MSSQL;
        }

        public override void CreateDb()
        {
            try
            {
                OpenConnection();
                ServerConnection l_sc = new ServerConnection((ProjeSabitiBilgileri.DBConnection as SqlConnection));
                l_Svr = new Microsoft.SqlServer.Management.Smo.Server(l_sc);
                Database db = l_Svr.Databases[DataBase.Trim()];
                if (db == null)
                {
                    db = new Database(l_Svr, DataBase);
                    db.Create();
                    l_Svr.ConnectionContext.ExecuteNonQuery(SqlScript());
                }
            }
            catch (SqlException)
            {
            }
        }

        private string SqlScript()
        {
            string dbstring = "";
            dbstring += "USE [BPROJE]" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "/****** Object:  Table [dbo].[PROJELER]    Script Date: 22.12.2014 17:29:01 ******/" + System.Environment.NewLine;
            dbstring += "SET ANSI_NULLS ON" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "SET QUOTED_IDENTIFIER ON" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "CREATE TABLE [dbo].[PROJELER](" + System.Environment.NewLine;
            dbstring += "	[ID] [int] IDENTITY(1,1) NOT NULL," + System.Environment.NewLine;
            dbstring += "	[PROJE_ADI] [nvarchar](50) NOT NULL," + System.Environment.NewLine;
            dbstring += " CONSTRAINT [PK_PROJELER] PRIMARY KEY CLUSTERED" + System.Environment.NewLine;
            dbstring += "(" + System.Environment.NewLine;
            dbstring += "	[ID] ASC" + System.Environment.NewLine;
            dbstring += ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]" + System.Environment.NewLine;
            dbstring += ") ON [PRIMARY]" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "/****** Object:  Table [dbo].[USERS]    Script Date: 22.12.2014 17:29:01 ******/" + System.Environment.NewLine;
            dbstring += "SET ANSI_NULLS ON" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "SET QUOTED_IDENTIFIER ON" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "CREATE TABLE [dbo].[USERS](" + System.Environment.NewLine;
            dbstring += "	[ID] [int] IDENTITY(1,1) NOT NULL," + System.Environment.NewLine;
            dbstring += "	[NAME] [nvarchar](50) NOT NULL," + System.Environment.NewLine;
            dbstring += "	[PASWORD] [nvarchar](50) NOT NULL," + System.Environment.NewLine;
            dbstring += "	[AD] [nvarchar](50) NULL," + System.Environment.NewLine;
            dbstring += "	[SOYAD] [nvarchar](50) NULL," + System.Environment.NewLine;
            dbstring += "	[YETKI] [bit] NOT NULL," + System.Environment.NewLine;
            dbstring += " CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED" + System.Environment.NewLine;
            dbstring += "(" + System.Environment.NewLine;
            dbstring += "	[ID] ASC" + System.Environment.NewLine;
            dbstring += ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]" + System.Environment.NewLine;
            dbstring += ") ON [PRIMARY]" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "/****** Object:  Table [dbo].[USER_PROJE]    Script Date: 22.12.2014 17:29:01 ******/" + System.Environment.NewLine;
            dbstring += "SET ANSI_NULLS ON" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "SET QUOTED_IDENTIFIER ON" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "CREATE TABLE [dbo].[USER_PROJE](" + System.Environment.NewLine;
            dbstring += "	[ID] [int] IDENTITY(1,1) NOT NULL," + System.Environment.NewLine;
            dbstring += "	[USER_ID] [int] NOT NULL," + System.Environment.NewLine;
            dbstring += "	[PROJE_ID] [int] NOT NULL," + System.Environment.NewLine;
            dbstring += " CONSTRAINT [PK_USER_PROJE] PRIMARY KEY CLUSTERED" + System.Environment.NewLine;
            dbstring += "(" + System.Environment.NewLine;
            dbstring += "	[ID] ASC" + System.Environment.NewLine;
            dbstring += ")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]" + System.Environment.NewLine;
            dbstring += ") ON [PRIMARY]" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "ALTER TABLE [dbo].[USER_PROJE]  WITH CHECK ADD  CONSTRAINT [FK_USER_PROJE_PROJELER] FOREIGN KEY([PROJE_ID])" + System.Environment.NewLine;
            dbstring += "REFERENCES [dbo].[PROJELER] ([ID])" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "ALTER TABLE [dbo].[USER_PROJE] CHECK CONSTRAINT [FK_USER_PROJE_PROJELER]" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "ALTER TABLE [dbo].[USER_PROJE]  WITH CHECK ADD  CONSTRAINT [FK_USER_PROJE_USER] FOREIGN KEY([USER_ID])" + System.Environment.NewLine;
            dbstring += "REFERENCES [dbo].[USERS] ([ID])" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            dbstring += "ALTER TABLE [dbo].[USER_PROJE] CHECK CONSTRAINT [FK_USER_PROJE_USER]" + System.Environment.NewLine;
            dbstring += "GO" + System.Environment.NewLine;
            return dbstring;
        }
        #region Implement edilen Fonsiyonlar
        public override List<string> ServerName()
        {
            List<string> l_Result = new List<string>();
            DataTable dt = SmoApplication.EnumAvailableSqlServers();
            foreach (DataRow dr in dt.Rows)
            {
                l_Result.Add(dr[0].ToString());
            }
            return l_Result;
        }

        public override void InsertUser(string p_UserName, string p_UserPass, string p_Name, string p_LastName, bool p_IsAdmin)
        {
            string l_InsertSql = "INSERT INTO [USERS] (NAME,PASWORD,AD,SOYAD,YETKI) VALUES (@PARAM1,@PARAM2,@PARAM3,@PARAM4,@PARAM5)";
            ChangeDatabase();
            string dsds = ProjeSabitiBilgileri.DBConnection.Database;
            SqlCommand L_cmd = new SqlCommand(l_InsertSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            L_cmd.Parameters.Add(new SqlParameter("PARAM1", p_UserName));
            L_cmd.Parameters.Add(new SqlParameter("PARAM2", p_UserPass));
            L_cmd.Parameters.Add(new SqlParameter("PARAM3", p_Name));
            L_cmd.Parameters.Add(new SqlParameter("PARAM4", p_LastName));
            L_cmd.Parameters.Add(new SqlParameter("PARAM5", p_IsAdmin));
            L_cmd.ExecuteNonQuery();
        }

        public override void InsertProje(string p_ProjeName)
        {
            ChangeDatabase();
            string l_InsertSql = "INSERT INTO PROJELER (PROJE_ADI) VALUES (@PARAM1)";
            SqlCommand L_cmd = new SqlCommand(l_InsertSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            L_cmd.Parameters.Add(new SqlParameter("PARAM1", p_ProjeName));
            L_cmd.ExecuteNonQuery();
        }

        public override void MatchProje_User(int p_ProjeID, List<int> p_UserIDs)
        {
            Dictionary<int, string> l_ExistingUSer = GetProjectUsers(p_ProjeID);
            if (l_ExistingUSer.Count > 0)
            {
                for (int i = 0; i < p_UserIDs.Count; i++)
                    MatchProje_User(p_ProjeID, p_UserIDs[i]);

                List<int> l_Olmayanlar = new List<int>();
                for (int i = 0; i < p_UserIDs.Count; i++)
                    if (!l_ExistingUSer.ContainsKey(p_UserIDs[i]))
                        l_Olmayanlar.Add(p_UserIDs[i]);
                DeleteMatchProje_User(p_ProjeID, l_Olmayanlar);
            }
            else
            {
                for (int i = 0; i < p_UserIDs.Count; i++)
                    MatchProje_User(p_ProjeID, p_UserIDs[i]);
            }
        }

        public override void MatchProje_User(int p_ProjeID, int p_UserID)
        {
            SqlCommand l_Selectcmd = new SqlCommand();
            l_Selectcmd.CommandText = "SELECT * FROM USER_PROJE WHERE USER_ID=" + p_UserID + " AND  PROJE_ID=" + p_ProjeID;
            l_Selectcmd.Connection = (ProjeSabitiBilgileri.DBConnection as SqlConnection);
            SqlDataAdapter a = new SqlDataAdapter(l_Selectcmd);
            DataTable dt = new DataTable();
            a.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                string l_InsertSql = "INSERT INTO USER_PROJE (USER_ID,PROJE_ID) VALUES (@PARAM1,@PARAM2)";
                SqlCommand L_cmd = new SqlCommand(l_InsertSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
                L_cmd.Parameters.Add(new SqlParameter("PARAM1", p_UserID));
                L_cmd.Parameters.Add(new SqlParameter("PARAM2", p_ProjeID));
                L_cmd.ExecuteNonQuery();
            }
        }

        public override void UpdateUser(int p_ID, string p_UserName, string p_UserPass, string p_Name, string p_LastName, bool p_IsAdmin)
        {
            string l_UpadateSql = "UPDATE  [USERS]  SET NAME=@PARAM1,PASWORD=@PARAM2,AD=@PARAM3,SOYAD=@PARAM4,YETKI=@PARAM5  WHERE ID=" + p_ID;
            ChangeDatabase();
            SqlCommand L_cmd = new SqlCommand(l_UpadateSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            L_cmd.Parameters.Add(new SqlParameter("PARAM1", p_UserName));
            L_cmd.Parameters.Add(new SqlParameter("PARAM2", p_UserPass));
            L_cmd.Parameters.Add(new SqlParameter("PARAM3", p_Name));
            L_cmd.Parameters.Add(new SqlParameter("PARAM4", p_LastName));
            L_cmd.Parameters.Add(new SqlParameter("PARAM5", p_IsAdmin));
            L_cmd.ExecuteNonQuery();
        }

        public override void DeleteMatchProje_User(int p_ProjeID, List<int> p_UserIDs)
        {
            ChangeDatabase();
            for (int i = 0; i < p_UserIDs.Count; i++)
            {
                string l_DeleteSql = "DELETE FROM  USER_PROJE  WHERE PROJE_ID=" + p_ProjeID + " AND USER_ID=" + p_UserIDs[i];
                SqlCommand L_cmd = new SqlCommand(l_DeleteSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
                L_cmd.ExecuteNonQuery();
            }
        }

        public override Dictionary<int, string> GetUsers()
        {
            ChangeDatabase();
            Dictionary<int, string> l_Result = new Dictionary<int, string>();
            string l_SelectSql = "SELECT * FROM [USERS]";
            SqlCommand L_cmd = new SqlCommand(l_SelectSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            DataTable l_dt = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(L_cmd))
            {
                a.Fill(l_dt);
                for (int i = 0; i < l_dt.Rows.Count; i++)
                {
                    l_Result.Add(Convert.ToInt32(l_dt.Rows[i]["ID"]), l_dt.Rows[i]["AD"].ToString() + " " + l_dt.Rows[i]["SOYAD"].ToString());
                }
            }
            return l_Result;
        }

        public override Dictionary<int, string> GetProjects()
        {
            ChangeDatabase();
            Dictionary<int, string> l_Result = new Dictionary<int, string>();
            string l_SelectSql = "SELECT * FROM PROJELER";
            SqlCommand L_cmd = new SqlCommand(l_SelectSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            DataTable l_dt = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(L_cmd))
            {
                a.Fill(l_dt);
                for (int i = 0; i < l_dt.Rows.Count; i++)
                {
                    l_Result.Add(Convert.ToInt32(l_dt.Rows[i]["ID"]), l_dt.Rows[i]["PROJE_ADI"].ToString());
                }
            }
            return l_Result;
        }

        public override Dictionary<int, string> GetProjectUsers(int p_ProjectID)
        {
            ChangeDatabase();
            Dictionary<int, string> l_Result = new Dictionary<int, string>();
            string l_SelectSql = "SELECT [USERS].[ID],[USERS].[AD],[USERS].[SOYAD]    \n" +
                                 "FROM [dbo].[USERS] \n" +
                                 "left join [USER_PROJE] \n" +
                                 "on [USERS].ID= [USER_PROJE].USER_ID \n" +
                                 "where [USER_PROJE].PROJE_ID =" + p_ProjectID;

            SqlCommand L_cmd = new SqlCommand(l_SelectSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            DataTable l_dt = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(L_cmd))
            {
                a.Fill(l_dt);
                for (int i = 0; i < l_dt.Rows.Count; i++)
                {
                    l_Result.Add(Convert.ToInt32(l_dt.Rows[i]["ID"]), l_dt.Rows[i]["AD"].ToString() + " " + l_dt.Rows[i]["SOYAD"].ToString());
                }
            }
            return l_Result;
        }

        public override Dictionary<int, string> GetUSerProjects(int p_UserID)
        {
            ChangeDatabase();
            Dictionary<int, string> l_Result = new Dictionary<int, string>();
            string l_SelectSql = "SELECT [PROJELER].[ID],[PROJELER].[PROJE_ADI]\n" +
                                "FROM [dbo].[PROJELER] \n" +
                                "left join [USER_PROJE] \n" +
                                "on [PROJELER].ID= [USER_PROJE].PROJE_ID \n" +
                                "where [USER_PROJE].USER_ID =" + p_UserID;

            SqlCommand L_cmd = new SqlCommand(l_SelectSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            DataTable l_dt = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(L_cmd))
            {
                a.Fill(l_dt);
                for (int i = 0; i < l_dt.Rows.Count; i++)
                {
                    l_Result.Add(Convert.ToInt32(l_dt.Rows[i]["ID"]), l_dt.Rows[i]["PROJE_ADI"].ToString());
                }
            }
            return l_Result;
        }

        protected override void OpenConnection()
        {
            if (ProjeSabitiBilgileri.DBConnection == null)
            {
                string l_SqlConnectionStrin = "Data Source=" + DB_Server + ";" +
                                                       "Initial Catalog=master;" +
                                                       "User id=" + DB_UserName + ";" +
                                                       "Password=" + DB_Pasword + ";";
                ProjeSabitiBilgileri.DBConnection = new System.Data.SqlClient.SqlConnection(l_SqlConnectionStrin);
            }
            else
            {
                if (ProjeSabitiBilgileri.DBConnection.State != ConnectionState.Open)
                    ProjeSabitiBilgileri.DBConnection.Open();
            }
        }

        public override bool DataBaseIsValide(string p_DataBaseName)
        {
            OpenConnection();
            ServerConnection l_sc = new ServerConnection((ProjeSabitiBilgileri.DBConnection as SqlConnection));
            Microsoft.SqlServer.Management.Smo.Server l_Svr = new Microsoft.SqlServer.Management.Smo.Server(l_sc);
            Database db = l_Svr.Databases[p_DataBaseName.Trim()];
            if (db == null)
                return false;
            else
                return true;
        }
        #endregion

        public override DataTable GetUserInfo(int p_UserID)
        {
            ChangeDatabase();
            string l_SelectSql = "SELECT * FROM [USERS] WHERE ID=" + p_UserID;
            SqlCommand L_cmd = new SqlCommand(l_SelectSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            DataTable l_Result = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(L_cmd))
            {
                a.Fill(l_Result);
            }
            return l_Result;
        }

        public override void DeleteUser(int p_UserID)
        {
            ChangeDatabase();
            string l_DeleteSql = "DELETE FROM USER_PROJE WHERE USER_ID=" + p_UserID;
            SqlCommand L_cmd = new SqlCommand(l_DeleteSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            L_cmd.ExecuteNonQuery();

            l_DeleteSql = "DELETE FROM [USERS] WHERE ID=" + p_UserID;
            L_cmd = new SqlCommand(l_DeleteSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            L_cmd.ExecuteNonQuery();
        }

        public override DataTable UserLogin(string p_UserName, string p_UserPass)
        {
            ChangeDatabase();
            string l_SelectSql = "SELECT * FROM [USERS] WHERE NAME COLLATE Latin1_General_CS_AS ='" + p_UserName + "' AND PASWORD COLLATE Latin1_General_CS_AS ='" + p_UserPass + "'";
            SqlCommand L_cmd = new SqlCommand(l_SelectSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            DataTable l_Result = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(L_cmd))
            {
                a.Fill(l_Result);
            }
            return l_Result;
        }

        public override void DeleteProje(int p_ProjeID)
        {
            ChangeDatabase();
            string l_DeleteSql = "DELETE FROM USER_PROJE WHERE PROJE_ID=" + p_ProjeID;
            SqlCommand L_cmd = new SqlCommand(l_DeleteSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            L_cmd.ExecuteNonQuery();
            string l_SqlSelect = "select PROJE_ADI from [PROJELER] WHERE ID=" + p_ProjeID;
            L_cmd = new SqlCommand(l_SqlSelect, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            using (SqlDataAdapter a = new SqlDataAdapter(L_cmd))
            {
                using (DataTable l_dt = new DataTable())
                {
                    a.Fill(l_dt);
                    if (l_dt.Rows.Count > 0)
                    {
                        try
                        {

                            string l_TableName = l_dt.Rows[0][0].ToString();
                            l_SqlSelect = "select spid, hostname, [program_name], open_tran, hostprocess, cmd " +
                                          "from master.dbo.sysprocesses " +
                                          "where dbid = db_id('" + l_TableName + "')";
                            L_cmd = new SqlCommand(l_SqlSelect, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
                            using (SqlDataAdapter B = new SqlDataAdapter(L_cmd))
                            {
                                using (DataTable l_dt1 = new DataTable())
                                {
                                    B.Fill(l_dt1);
                                    string l_SqlDropDB = "";
                                    if (l_dt1.Rows.Count > 0)
                                    {
                                        l_SqlDropDB = "USE master\n" +
                                                      "kill " + l_dt1.Rows[0]["spid"].ToString() + "\n" +
                                                      "IF EXISTS(select * from sys.databases where name='" + l_TableName + "') DROP DATABASE " + l_TableName;
                                    }
                                    else
                                    {
                                        l_SqlDropDB = "USE master\n" +
                                                      "IF EXISTS(select * from sys.databases where name='" + l_TableName + "') DROP DATABASE " + l_TableName;
                                    }

                                    L_cmd = new SqlCommand(l_SqlDropDB, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
                                    L_cmd.ExecuteNonQuery();
                                }
                            }

                        }
                        catch (SqlException _e)
                        {
                            MessageBox.Show(_e.Message);
                        }
                    }
                }
            }
            l_DeleteSql = "DELETE FROM [PROJELER] WHERE ID=" + p_ProjeID;
            L_cmd = new SqlCommand(l_DeleteSql, (ProjeSabitiBilgileri.DBConnection as SqlConnection));
            L_cmd.ExecuteNonQuery();
        }
    }
}
