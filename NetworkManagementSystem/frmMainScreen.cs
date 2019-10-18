using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using TatukGIS.NDK;
using System.IO;
using Server.ProfeBilgi;

namespace NetworkManagementSystem
{
    public partial class frmMainScreen : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void GisLoad()
        {
             
        }

        private void btnAddLayer_ItemClick(object sender, ItemClickEventArgs e)
        {
            string txtNewProjeAdi = "CIHAN";
            string l_SqlConnectionStrin = "Data Source=" + "178.157.9.195" + ";" +
                                         "Initial Catalog=master;" +
                                         "User id=" + "sa" + ";" +
                                         "Password=" + "Terra2010*" + ";";
            ProjeSabitiBilgileri.DBConnection = new System.Data.SqlClient.SqlConnection(l_SqlConnectionStrin);
            gisMapViewer.Open(@"C:\Users\Dev2\Desktop\Test\box.ttkls");
            //gisMapViewer.Open("C:\\Users\\Dev2\\Desktop\\Test\\USB Sürücüsü\\Test\\Layers\\Test.ttkgp");
            //gisMapViewer.Open("C:\\Users\\Dev2\\Desktop\\Test\\EDITOR\\EDITOR.ttkgp");
            if (gisMapViewer.Items.Count > 0)
            {
                if (!txtNewProjeAdi.Equals(string.Empty))
                {
                    char[] l_unwanted = "İışŞçÇöÖğĞüÜ <>/|.:,\\*-_+?#!^$%@&{[()]}=0123456789".ToCharArray();
                    string l_TempFile = System.IO.Path.GetTempPath() + "tmp.ttkls";
                    if (txtNewProjeAdi.IndexOfAny(l_unwanted) == -1)
                    {
                        SqlCommand cmd = new SqlCommand();
                        if (ProjeSabitiBilgileri.DBConnection != null)
                        {
                            if (ProjeSabitiBilgileri.DBConnection.State != ConnectionState.Open)
                                ProjeSabitiBilgileri.DBConnection.Open();
                            if (false/*ProjeSabitiBilgileri.ServerOperation.DataBaseIsValide(txtNewProjeAdi.ToUpper())*/)
                            {
                                MessageBox.Show("bu proje mevcut");
                            }
                            else
                            {
                                cmd.Connection = (ProjeSabitiBilgileri.DBConnection as SqlConnection);
                                cmd.CommandText = "Create Database " + txtNewProjeAdi.ToUpper().Trim();
                                //cmd.ExecuteNonQuery();
                                // ProjeSabitiBilgileri.ServerOperation.InsertProje(txtNewProjeAdi.ToUpper().Trim());
                                for (int i = 0; i < gisMapViewer.Items.Count; i++)
                                {
                                    TGIS_LayerVector l_exportlayer = null;// ((gisMapViewer.Items as TGIS_List)[i] as TGIS_LayerVector);
                                    ////TGIS_LayerVector l_exportlayer = new TGIS_LayerVector();// Existing Shape
                                    //TGIS_Extent currentextent = l_exportlayer.Extent;
                                    //string l_LayerName = l_exportlayer.Name;
                                    //TGIS_LayerSqlAdo l_LayerSqlAdoNet = new TGIS_LayerSqlAdo(); //  TGIS_LayerSqlAdoNet();
                                    //l_LayerSqlAdoNet.Extent = currentextent;
                                    //l_LayerSqlAdoNet.set_SQLParameter("Layer", l_LayerName+"test");
                                    //l_LayerSqlAdoNet.set_SQLParameter("Dialect", "MSSQL");
                                    //l_LayerSqlAdoNet.set_SQLParameter("Storage", "NATIVE");
                                    //l_LayerSqlAdoNet.set_SQLParameter("Provider", "System.Data.SqlClient");
                                    //string l_ConnectionString = "ADONET=Persist Security Info=True;User ID=sa;Password=Terra2010*;Initial Catalog=CIHAN;Server=178.157.9.195;MultipleActiveResultSets=True";
                                    //l_LayerSqlAdoNet.set_SQLParameter("ADONET", l_ConnectionString);
                                    //l_LayerSqlAdoNet.MultiUserMode = TGIS_MultiUser.gisMultiUser;
                                    //l_LayerSqlAdoNet.CS = l_exportlayer.CS;
                                    //l_LayerSqlAdoNet.ImportLayer(l_exportlayer, currentextent, l_exportlayer.DefaultShapeType, "", false);
                                    if (l_exportlayer != null)
                                    {
                                        //SabitFormlar.SetGlobalProcessBarPercentBy(l_exportlayer.Name + " katmanı export", l_GisView.m_GISViewer.Items.Count, i);
                                        try
                                        {
                                            string tempPath = System.IO.Path.GetTempPath() + "temp.ttkls";
                                            using (StreamWriter writer = new StreamWriter(tempPath, false))
                                            {
                                                //writer.WriteLine("[TatukGIS Layer]");
                                                //writer.WriteLine("ADO=Provider=SQLOLEDB.1;Password=" + "Terra2010*"+ ";" +
                                                //                 "Persist Security Info=True;User ID=" + "sa" + ";" +
                                                //                 "Initial Catalog=" + txtNewProjeAdi.ToUpper() + ";" +
                                                //                 "Data Source=" + "178.157.15.114");
                                                //writer.WriteLine("Dialect=MSSQL");
                                                //writer.WriteLine("Layer=" + l_exportlayer.Name);
                                                //writer.Flush();
                                                //writer.Close();
                                                writer.WriteLine("[TatukGIS Layer]");
                                                writer.WriteLine("Layer=" + l_exportlayer.Name);
                                                writer.WriteLine("Dialect=MSSQL");
                                                writer.WriteLine("Storage=NATIVE");
                                                writer.WriteLine("Provider=System.Data.SqlClient");
                                                writer.WriteLine("ADONET=Persist Security Info=true;Password=" + "Terra2010*" + ";" +
                                                                 "User ID=" + "sa" + ";" +
                                                                 "Initial Catalog=" + txtNewProjeAdi.ToUpper() + ";" +
                                                                 "Data Source=" + "178.157.9.195");



                             


                                                writer.Flush();
                                                writer.Close();

                                            }


                                            TGIS_LayerVector lm = (TGIS_LayerVector)TGIS_Utils.GisCreateLayer("", tempPath);
                                            if (lm != null)
                                            {
                                                lm.ImportLayer(l_exportlayer, l_exportlayer.Extent, l_exportlayer.DefaultShapeType, "", false);
                                            };
                                        }
                                        catch (Exception _e)
                                        {
                                            Console.WriteLine(_e.ToString());
                                        }
                                    }
                                }
                                //SabitFormlar.CloseGlobalProcessBar();

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Proje Adında Aşağıda Belirtilen Özel Karakterler KULLANILAMAZ\n" + new string(l_unwanted), "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}