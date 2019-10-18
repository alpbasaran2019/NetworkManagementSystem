namespace NetworkManagementSystem
{
    partial class frmMainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            TatukGIS.NDK.WinForms.TGIS_ControlLegendDialogOptions tgıS_ControlLegendDialogOptions2 = new TatukGIS.NDK.WinForms.TGIS_ControlLegendDialogOptions();
            TatukGIS.NDK.WinForms.TGIS_ControlLegendDialogOptions tgıS_ControlLegendDialogOptions1 = new TatukGIS.NDK.WinForms.TGIS_ControlLegendDialogOptions();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddLayer = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dckManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gisLegend = new TatukGIS.NDK.WinForms.TGIS_ControlLegend();
            this.gisMapViewer = new TatukGIS.NDK.WinForms.TGIS_ViewerWnd();
            this.gisMapLegend = new TatukGIS.NDK.WinForms.TGIS_ControlLegend();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dckManager)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnAddLayer});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.Size = new System.Drawing.Size(870, 83);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnAddLayer
            // 
            this.btnAddLayer.Caption = "Layer Ekle";
            this.btnAddLayer.Id = 1;
            this.btnAddLayer.Name = "btnAddLayer";
            this.btnAddLayer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddLayer_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddLayer);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 460);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(870, 21);
            // 
            // dckManager
            // 
            this.dckManager.Form = this;
            this.dckManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dckManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel1.ID = new System.Guid("d0198569-ccd0-4c14-8d82-6030fd368c82");
            this.dockPanel1.Location = new System.Drawing.Point(670, 83);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedSizeFactor = 0D;
            this.dockPanel1.Size = new System.Drawing.Size(200, 377);
            this.dockPanel1.Text = "dockPanel1";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.gisMapLegend);
            this.dockPanel1_Container.Controls.Add(this.gisLegend);
            this.dockPanel1_Container.Location = new System.Drawing.Point(5, 38);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 335);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // gisLegend
            // 
            this.gisLegend.CheckBoxes = true;
            this.gisLegend.CompactView = false;
            tgıS_ControlLegendDialogOptions2.VectorWizardUniqueLimit = 256;
            tgıS_ControlLegendDialogOptions2.VectorWizardUniqueSearchLimit = 16384;
            this.gisLegend.DialogOptions = tgıS_ControlLegendDialogOptions2;
            this.gisLegend.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.gisLegend.FullRowSelect = true;
            this.gisLegend.GIS_Viewer = null;
            this.gisLegend.Location = new System.Drawing.Point(0, 0);
            this.gisLegend.Mode = TatukGIS.NDK.WinForms.TGIS_ControlLegendMode.Layers;
            this.gisLegend.Name = "gisLegend";
            this.gisLegend.Options = ((TatukGIS.NDK.WinForms.TGIS_ControlLegendOption)(((((((TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.AllowMove | TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.AllowActive) 
            | TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.AllowExpand) 
            | TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.AllowParams) 
            | TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.AllowSelect) 
            | TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.ShowSubLayers) 
            | TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.AllowParamsVisible)));
            this.gisLegend.ReverseOrder = false;
            this.gisLegend.ShowLines = false;
            this.gisLegend.ShowPlusMinus = false;
            this.gisLegend.Size = new System.Drawing.Size(121, 97);
            this.gisLegend.TabIndex = 0;
            // 
            // gisMapViewer
            // 
            this.gisMapViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gisMapViewer.Location = new System.Drawing.Point(0, 83);
            this.gisMapViewer.Name = "gisMapViewer";
            this.gisMapViewer.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gisMapViewer.Size = new System.Drawing.Size(670, 377);
            this.gisMapViewer.TabIndex = 4;
            // 
            // gisMapLegend
            // 
            this.gisMapLegend.CheckBoxes = true;
            this.gisMapLegend.CompactView = false;
            tgıS_ControlLegendDialogOptions1.VectorWizardUniqueLimit = 256;
            tgıS_ControlLegendDialogOptions1.VectorWizardUniqueSearchLimit = 16384;
            this.gisMapLegend.DialogOptions = tgıS_ControlLegendDialogOptions1;
            this.gisMapLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gisMapLegend.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.gisMapLegend.FullRowSelect = true;
            this.gisMapLegend.GIS_Viewer = this.gisMapViewer;
            this.gisMapLegend.Location = new System.Drawing.Point(0, 0);
            this.gisMapLegend.Mode = TatukGIS.NDK.WinForms.TGIS_ControlLegendMode.Layers;
            this.gisMapLegend.Name = "gisMapLegend";
            this.gisMapLegend.Options = ((TatukGIS.NDK.WinForms.TGIS_ControlLegendOption)(((((((TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.AllowMove | TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.AllowActive) 
            | TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.AllowExpand) 
            | TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.AllowParams) 
            | TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.AllowSelect) 
            | TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.ShowSubLayers) 
            | TatukGIS.NDK.WinForms.TGIS_ControlLegendOption.AllowParamsVisible)));
            this.gisMapLegend.ReverseOrder = false;
            this.gisMapLegend.ShowLines = false;
            this.gisMapLegend.ShowPlusMinus = false;
            this.gisMapLegend.Size = new System.Drawing.Size(191, 335);
            this.gisMapLegend.TabIndex = 1;
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 481);
            this.Controls.Add(this.gisMapViewer);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMainScreen";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Şebeke Yönetim Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dckManager)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnAddLayer;
        private DevExpress.XtraBars.Docking.DockManager dckManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private TatukGIS.NDK.WinForms.TGIS_ControlLegend gisLegend;
        private TatukGIS.NDK.WinForms.TGIS_ViewerWnd gisMapViewer;
        private TatukGIS.NDK.WinForms.TGIS_ControlLegend gisMapLegend;
    }
}