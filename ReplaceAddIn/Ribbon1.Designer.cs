﻿
namespace ReplaceAddIn
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonBox box7;
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.cboTemplate = this.Factory.CreateRibbonComboBox();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.box2 = this.Factory.CreateRibbonBox();
            this.box4 = this.Factory.CreateRibbonBox();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
            this.btnSelectSource = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.box9 = this.Factory.CreateRibbonBox();
            this.cboTags = this.Factory.CreateRibbonComboBox();
            this.box8 = this.Factory.CreateRibbonBox();
            this.box10 = this.Factory.CreateRibbonBox();
            this.label2 = this.Factory.CreateRibbonLabel();
            this.box11 = this.Factory.CreateRibbonBox();
            this.btnSelectTag = this.Factory.CreateRibbonButton();
            box7 = this.Factory.CreateRibbonBox();
            box7.SuspendLayout();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.box2.SuspendLayout();
            this.box4.SuspendLayout();
            this.buttonGroup1.SuspendLayout();
            this.group2.SuspendLayout();
            this.box9.SuspendLayout();
            this.box8.SuspendLayout();
            this.box10.SuspendLayout();
            this.box11.SuspendLayout();
            this.SuspendLayout();
            // 
            // box7
            // 
            box7.Items.Add(this.cboTemplate);
            box7.Name = "box7";
            // 
            // cboTemplate
            // 
            ribbonDropDownItemImpl1.Label = "BBKP";
            ribbonDropDownItemImpl2.Label = "MGUQ";
            ribbonDropDownItemImpl3.Label = "KTTC";
            this.cboTemplate.Items.Add(ribbonDropDownItemImpl1);
            this.cboTemplate.Items.Add(ribbonDropDownItemImpl2);
            this.cboTemplate.Items.Add(ribbonDropDownItemImpl3);
            this.cboTemplate.Label = "Mẫu tài liệu";
            this.cboTemplate.Name = "cboTemplate";
            this.cboTemplate.Text = null;
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(box7);
            this.group1.Items.Add(this.box2);
            this.group1.Label = "Select resource";
            this.group1.Name = "group1";
            // 
            // box2
            // 
            this.box2.Items.Add(this.box4);
            this.box2.Items.Add(this.buttonGroup1);
            this.box2.Name = "box2";
            // 
            // box4
            // 
            this.box4.Items.Add(this.label1);
            this.box4.Name = "box4";
            // 
            // label1
            // 
            this.label1.Label = "Nguồn thẻ gán";
            this.label1.Name = "label1";
            // 
            // buttonGroup1
            // 
            this.buttonGroup1.Items.Add(this.btnSelectSource);
            this.buttonGroup1.Name = "buttonGroup1";
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectSource.Image")));
            this.btnSelectSource.Label = "Chọn file";
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.ShowImage = true;
            this.btnSelectSource.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSelectSource_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.box9);
            this.group2.Items.Add(this.box8);
            this.group2.Label = "Add tag to page";
            this.group2.Name = "group2";
            // 
            // box9
            // 
            this.box9.Items.Add(this.cboTags);
            this.box9.Name = "box9";
            // 
            // cboTags
            // 
            this.cboTags.Label = "DS thẻ";
            this.cboTags.Name = "cboTags";
            this.cboTags.Text = null;
            // 
            // box8
            // 
            this.box8.Items.Add(this.box10);
            this.box8.Items.Add(this.box11);
            this.box8.Name = "box8";
            // 
            // box10
            // 
            this.box10.Items.Add(this.label2);
            this.box10.Name = "box10";
            // 
            // label2
            // 
            this.label2.Label = "Thao tác";
            this.label2.Name = "label2";
            // 
            // box11
            // 
            this.box11.Items.Add(this.btnSelectTag);
            this.box11.Name = "box11";
            // 
            // btnSelectTag
            // 
            this.btnSelectTag.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectTag.Image")));
            this.btnSelectTag.Label = "Gán thẻ";
            this.btnSelectTag.Name = "btnSelectTag";
            this.btnSelectTag.ShowImage = true;
            this.btnSelectTag.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnSelectTag_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            box7.ResumeLayout(false);
            box7.PerformLayout();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.box4.ResumeLayout(false);
            this.box4.PerformLayout();
            this.buttonGroup1.ResumeLayout(false);
            this.buttonGroup1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.box9.ResumeLayout(false);
            this.box9.PerformLayout();
            this.box8.ResumeLayout(false);
            this.box8.PerformLayout();
            this.box10.ResumeLayout(false);
            this.box10.PerformLayout();
            this.box11.ResumeLayout(false);
            this.box11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSelectSource;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox cboTags;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnSelectTag;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label2;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox cboTemplate;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box9;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box8;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box10;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box11;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
