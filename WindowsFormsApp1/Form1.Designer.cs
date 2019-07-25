using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace WindowsFormsApp1
{
    partial class Form1
    {

        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码
        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression4 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression5 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule6 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression6 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.CheckStatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.grdSample = new DevExpress.XtraGrid.GridControl();
            this.gvSample = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.ChannelSample = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grdClmnID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.SequenceNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.SampleName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.SampleType = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.PositionNo = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.SampleBlank = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.SampleBlankType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ChannelA = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.APeakArea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.APeakArea2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.AReferArea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ChannelB = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.BPeakArea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BPeakArea2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BReferArea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ChannelC = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.CPeakArea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CPeakArea2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CReferArea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ChannelD = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.DPeakArea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.DPeakArea2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.DReferArea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Conc = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.AConcentration = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.BConcentration = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CConcentration = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.DConcentration = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Unit = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.ChannelAUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpCmbChannelUnit1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ChannelBUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpCmbChannelUnit2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ChannelCUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpCmbChannelUnit3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ChannelDUnit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.rpCmbChannelUnit4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.Dilution = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.DiluteFactor = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.DilutePowerA = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.DilutePowerB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.DilutePowerC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.DilutePowerD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CurveNo = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.CurveA = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CurveB = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CurveC = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.CurveD = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleBlankType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCmbChannelUnit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCmbChannelUnit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCmbChannelUnit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCmbChannelUnit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckStatus
            // 
            this.CheckStatus.AppearanceCell.Options.UseTextOptions = true;
            this.CheckStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.CheckStatus, "CheckStatus");
            this.CheckStatus.FieldName = "CheckStatus";
            this.CheckStatus.MinWidth = 50;
            this.CheckStatus.Name = "CheckStatus";
            this.CheckStatus.OptionsColumn.AllowEdit = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.Name = "gridColumn2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // grdSample
            // 
            this.grdSample.AllowDrop = true;
            resources.ApplyResources(this.grdSample, "grdSample");
            this.grdSample.MainView = this.gvSample;
            this.grdSample.Name = "grdSample";
            this.grdSample.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.SampleBlankType,
            this.repositoryItemTextEdit1,
            this.rpCmbChannelUnit1,
            this.rpCmbChannelUnit2,
            this.rpCmbChannelUnit3,
            this.rpCmbChannelUnit4,
            this.repositoryItemPopupContainerEdit1});
            this.grdSample.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSample});
            // 
            // gvSample
            // 
            this.gvSample.Appearance.EvenRow.BackColor = ((System.Drawing.Color)(resources.GetObject("gvSample.Appearance.EvenRow.BackColor")));
            this.gvSample.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvSample.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvSample.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSample.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.ChannelSample,
            this.ChannelA,
            this.ChannelB,
            this.ChannelC,
            this.ChannelD,
            this.Conc,
            this.Unit,
            this.Dilution,
            this.CurveNo});
            this.gvSample.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.grdClmnID,
            this.SequenceNo,
            this.CheckStatus,
            this.SampleName,
            this.SampleType,
            this.PositionNo,
            this.SampleBlank,
            this.APeakArea,
            this.APeakArea2,
            this.AReferArea,
            this.BPeakArea,
            this.BPeakArea2,
            this.BReferArea,
            this.CPeakArea,
            this.CPeakArea2,
            this.CReferArea,
            this.DPeakArea,
            this.DPeakArea2,
            this.DReferArea,
            this.AConcentration,
            this.BConcentration,
            this.CConcentration,
            this.DConcentration,
            this.ChannelAUnit,
            this.ChannelBUnit,
            this.ChannelCUnit,
            this.ChannelDUnit,
            this.DiluteFactor,
            this.DilutePowerA,
            this.DilutePowerB,
            this.DilutePowerC,
            this.DilutePowerD,
            this.CurveA,
            this.CurveB,
            this.CurveC,
            this.CurveD});
            gridFormatRule1.Column = this.CheckStatus;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("resource.BackColor")));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "[CheckStatus] = \'正测\'";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.Column = this.CheckStatus;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("resource.BackColor1")));
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "[CheckStatus] = \'已测\'";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            gridFormatRule3.Column = this.CheckStatus;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleExpression3.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("resource.BackColor2")));
            formatConditionRuleExpression3.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression3.Expression = "[CheckStatus] = \'已测(异常)\'";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            gridFormatRule4.Column = this.CheckStatus;
            gridFormatRule4.Name = "Format3";
            formatConditionRuleExpression4.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("resource.BackColor3")));
            formatConditionRuleExpression4.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression4.Expression = "[CheckStatus] = \'超标\'";
            gridFormatRule4.Rule = formatConditionRuleExpression4;
            gridFormatRule5.Column = this.CheckStatus;
            gridFormatRule5.Name = "Format4";
            formatConditionRuleExpression5.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("resource.BackColor4")));
            formatConditionRuleExpression5.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression5.Expression = "[CheckStatus] = \'稀释\'";
            gridFormatRule5.Rule = formatConditionRuleExpression5;
            gridFormatRule6.Column = this.CheckStatus;
            gridFormatRule6.Name = "Format5";
            formatConditionRuleExpression6.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("resource.BackColor5")));
            formatConditionRuleExpression6.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression6.Expression = "[CheckStatus] = \'参比溢出\'";
            gridFormatRule6.Rule = formatConditionRuleExpression6;
            this.gvSample.FormatRules.Add(gridFormatRule1);
            this.gvSample.FormatRules.Add(gridFormatRule2);
            this.gvSample.FormatRules.Add(gridFormatRule3);
            this.gvSample.FormatRules.Add(gridFormatRule4);
            this.gvSample.FormatRules.Add(gridFormatRule5);
            this.gvSample.FormatRules.Add(gridFormatRule6);
            this.gvSample.GridControl = this.grdSample;
            this.gvSample.Name = "gvSample";
            this.gvSample.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
            this.gvSample.OptionsCustomization.AllowBandMoving = false;
            this.gvSample.OptionsCustomization.AllowColumnMoving = false;
            this.gvSample.OptionsCustomization.AllowFilter = false;
            this.gvSample.OptionsCustomization.AllowQuickHideColumns = false;
            this.gvSample.OptionsCustomization.AllowSort = false;
            this.gvSample.OptionsFind.FindNullPrompt = "输入查找内容...";
            this.gvSample.OptionsMenu.EnableColumnMenu = false;
            this.gvSample.OptionsSelection.MultiSelect = true;
            this.gvSample.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gvSample.OptionsView.ColumnAutoWidth = false;
            this.gvSample.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSample.OptionsView.EnableAppearanceOddRow = true;
            this.gvSample.OptionsView.ShowGroupPanel = false;
            // 
            // ChannelSample
            // 
            this.ChannelSample.AppearanceHeader.Options.UseTextOptions = true;
            this.ChannelSample.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.ChannelSample, "ChannelSample");
            this.ChannelSample.Columns.Add(this.grdClmnID);
            this.ChannelSample.Columns.Add(this.SequenceNo);
            this.ChannelSample.Columns.Add(this.CheckStatus);
            this.ChannelSample.Columns.Add(this.SampleName);
            this.ChannelSample.Columns.Add(this.SampleType);
            this.ChannelSample.Columns.Add(this.PositionNo);
            this.ChannelSample.Columns.Add(this.SampleBlank);
            this.ChannelSample.VisibleIndex = 0;
            // 
            // grdClmnID
            // 
            this.grdClmnID.AppearanceCell.Options.UseTextOptions = true;
            this.grdClmnID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.grdClmnID, "grdClmnID");
            this.grdClmnID.FieldName = "ID";
            this.grdClmnID.MinWidth = 50;
            this.grdClmnID.Name = "grdClmnID";
            // 
            // SequenceNo
            // 
            this.SequenceNo.AppearanceCell.Options.UseTextOptions = true;
            this.SequenceNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.SequenceNo, "SequenceNo");
            this.SequenceNo.FieldName = "SequenceNo";
            this.SequenceNo.MinWidth = 40;
            this.SequenceNo.Name = "SequenceNo";
            this.SequenceNo.OptionsColumn.FixedWidth = true;
            this.SequenceNo.OptionsColumn.ReadOnly = true;
            // 
            // SampleName
            // 
            this.SampleName.AppearanceCell.Options.UseTextOptions = true;
            this.SampleName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.SampleName, "SampleName");
            this.SampleName.FieldName = "SampleName";
            this.SampleName.MinWidth = 50;
            this.SampleName.Name = "SampleName";
            // 
            // SampleType
            // 
            this.SampleType.AppearanceCell.Options.UseTextOptions = true;
            this.SampleType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.SampleType, "SampleType");
            this.SampleType.ColumnEdit = this.repositoryItemTextEdit1;
            this.SampleType.FieldName = "SampleType";
            this.SampleType.MinWidth = 50;
            this.SampleType.Name = "SampleType";
            this.SampleType.OptionsColumn.AllowEdit = false;
            // 
            // repositoryItemTextEdit1
            // 
            resources.ApplyResources(this.repositoryItemTextEdit1, "repositoryItemTextEdit1");
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // PositionNo
            // 
            this.PositionNo.AppearanceCell.Options.UseTextOptions = true;
            this.PositionNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.PositionNo, "PositionNo");
            this.PositionNo.FieldName = "PositionNo";
            this.PositionNo.MinWidth = 40;
            this.PositionNo.Name = "PositionNo";
            this.PositionNo.OptionsColumn.FixedWidth = true;
            // 
            // SampleBlank
            // 
            this.SampleBlank.AppearanceCell.Options.UseTextOptions = true;
            this.SampleBlank.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SampleBlank.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.SampleBlank, "SampleBlank");
            this.SampleBlank.ColumnEdit = this.SampleBlankType;
            this.SampleBlank.FieldName = "SampleBlank";
            this.SampleBlank.Name = "SampleBlank";
            // 
            // SampleBlankType
            // 
            resources.ApplyResources(this.SampleBlankType, "SampleBlankType");
            this.SampleBlankType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("SampleBlankType.Buttons"))))});
            this.SampleBlankType.Name = "SampleBlankType";
            // 
            // ChannelA
            // 
            this.ChannelA.AppearanceHeader.Options.UseTextOptions = true;
            this.ChannelA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.ChannelA, "ChannelA");
            this.ChannelA.Columns.Add(this.APeakArea);
            this.ChannelA.Columns.Add(this.APeakArea2);
            this.ChannelA.Columns.Add(this.AReferArea);
            this.ChannelA.VisibleIndex = 1;
            // 
            // APeakArea
            // 
            this.APeakArea.AppearanceCell.Options.UseTextOptions = true;
            this.APeakArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.APeakArea, "APeakArea");
            this.APeakArea.FieldName = "APeakArea";
            this.APeakArea.MinWidth = 50;
            this.APeakArea.Name = "APeakArea";
            this.APeakArea.OptionsColumn.AllowEdit = false;
            this.APeakArea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.APeakArea.OptionsColumn.ReadOnly = true;
            // 
            // APeakArea2
            // 
            this.APeakArea2.AppearanceCell.Options.UseTextOptions = true;
            this.APeakArea2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.APeakArea2, "APeakArea2");
            this.APeakArea2.FieldName = "APeakArea2";
            this.APeakArea2.MinWidth = 50;
            this.APeakArea2.Name = "APeakArea2";
            this.APeakArea2.OptionsColumn.AllowEdit = false;
            this.APeakArea2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.APeakArea2.OptionsColumn.ReadOnly = true;
            // 
            // AReferArea
            // 
            this.AReferArea.AppearanceCell.Options.UseTextOptions = true;
            this.AReferArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.AReferArea, "AReferArea");
            this.AReferArea.FieldName = "AReferArea";
            this.AReferArea.MinWidth = 50;
            this.AReferArea.Name = "AReferArea";
            this.AReferArea.OptionsColumn.AllowEdit = false;
            this.AReferArea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.AReferArea.OptionsColumn.ReadOnly = true;
            // 
            // ChannelB
            // 
            this.ChannelB.AppearanceHeader.Options.UseTextOptions = true;
            this.ChannelB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.ChannelB, "ChannelB");
            this.ChannelB.Columns.Add(this.BPeakArea);
            this.ChannelB.Columns.Add(this.BPeakArea2);
            this.ChannelB.Columns.Add(this.BReferArea);
            this.ChannelB.VisibleIndex = 2;
            // 
            // BPeakArea
            // 
            this.BPeakArea.AppearanceCell.Options.UseTextOptions = true;
            this.BPeakArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.BPeakArea, "BPeakArea");
            this.BPeakArea.FieldName = "BPeakArea";
            this.BPeakArea.MinWidth = 50;
            this.BPeakArea.Name = "BPeakArea";
            this.BPeakArea.OptionsColumn.AllowEdit = false;
            this.BPeakArea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.BPeakArea.OptionsColumn.ReadOnly = true;
            // 
            // BPeakArea2
            // 
            this.BPeakArea2.AppearanceCell.Options.UseTextOptions = true;
            this.BPeakArea2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.BPeakArea2, "BPeakArea2");
            this.BPeakArea2.FieldName = "BPeakArea2";
            this.BPeakArea2.MinWidth = 50;
            this.BPeakArea2.Name = "BPeakArea2";
            this.BPeakArea2.OptionsColumn.AllowEdit = false;
            this.BPeakArea2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.BPeakArea2.OptionsColumn.ReadOnly = true;
            // 
            // BReferArea
            // 
            this.BReferArea.AppearanceCell.Options.UseTextOptions = true;
            this.BReferArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.BReferArea, "BReferArea");
            this.BReferArea.FieldName = "BReferArea";
            this.BReferArea.MinWidth = 50;
            this.BReferArea.Name = "BReferArea";
            this.BReferArea.OptionsColumn.AllowEdit = false;
            this.BReferArea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.BReferArea.OptionsColumn.ReadOnly = true;
            // 
            // ChannelC
            // 
            this.ChannelC.AppearanceHeader.Options.UseTextOptions = true;
            this.ChannelC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.ChannelC, "ChannelC");
            this.ChannelC.Columns.Add(this.CPeakArea);
            this.ChannelC.Columns.Add(this.CPeakArea2);
            this.ChannelC.Columns.Add(this.CReferArea);
            this.ChannelC.VisibleIndex = 3;
            // 
            // CPeakArea
            // 
            this.CPeakArea.AppearanceCell.Options.UseTextOptions = true;
            this.CPeakArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.CPeakArea, "CPeakArea");
            this.CPeakArea.FieldName = "CPeakArea";
            this.CPeakArea.MinWidth = 50;
            this.CPeakArea.Name = "CPeakArea";
            this.CPeakArea.OptionsColumn.AllowEdit = false;
            this.CPeakArea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.CPeakArea.OptionsColumn.ReadOnly = true;
            // 
            // CPeakArea2
            // 
            this.CPeakArea2.AppearanceCell.Options.UseTextOptions = true;
            this.CPeakArea2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.CPeakArea2, "CPeakArea2");
            this.CPeakArea2.FieldName = "CPeakArea2";
            this.CPeakArea2.MinWidth = 50;
            this.CPeakArea2.Name = "CPeakArea2";
            this.CPeakArea2.OptionsColumn.AllowEdit = false;
            this.CPeakArea2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.CPeakArea2.OptionsColumn.ReadOnly = true;
            // 
            // CReferArea
            // 
            this.CReferArea.AppearanceCell.Options.UseTextOptions = true;
            this.CReferArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.CReferArea, "CReferArea");
            this.CReferArea.FieldName = "CReferArea";
            this.CReferArea.MinWidth = 50;
            this.CReferArea.Name = "CReferArea";
            this.CReferArea.OptionsColumn.AllowEdit = false;
            this.CReferArea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.CReferArea.OptionsColumn.ReadOnly = true;
            // 
            // ChannelD
            // 
            this.ChannelD.AppearanceHeader.Options.UseTextOptions = true;
            this.ChannelD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.ChannelD, "ChannelD");
            this.ChannelD.Columns.Add(this.DPeakArea);
            this.ChannelD.Columns.Add(this.DPeakArea2);
            this.ChannelD.Columns.Add(this.DReferArea);
            this.ChannelD.VisibleIndex = 4;
            // 
            // DPeakArea
            // 
            this.DPeakArea.AppearanceCell.Options.UseTextOptions = true;
            this.DPeakArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.DPeakArea, "DPeakArea");
            this.DPeakArea.FieldName = "DPeakArea";
            this.DPeakArea.MinWidth = 50;
            this.DPeakArea.Name = "DPeakArea";
            this.DPeakArea.OptionsColumn.AllowEdit = false;
            this.DPeakArea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DPeakArea.OptionsColumn.ReadOnly = true;
            // 
            // DPeakArea2
            // 
            this.DPeakArea2.AppearanceCell.Options.UseTextOptions = true;
            this.DPeakArea2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.DPeakArea2, "DPeakArea2");
            this.DPeakArea2.FieldName = "DPeakArea2";
            this.DPeakArea2.MinWidth = 50;
            this.DPeakArea2.Name = "DPeakArea2";
            this.DPeakArea2.OptionsColumn.AllowEdit = false;
            this.DPeakArea2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DPeakArea2.OptionsColumn.ReadOnly = true;
            // 
            // DReferArea
            // 
            this.DReferArea.AppearanceCell.Options.UseTextOptions = true;
            this.DReferArea.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.DReferArea, "DReferArea");
            this.DReferArea.FieldName = "DReferArea";
            this.DReferArea.MinWidth = 50;
            this.DReferArea.Name = "DReferArea";
            this.DReferArea.OptionsColumn.AllowEdit = false;
            this.DReferArea.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.DReferArea.OptionsColumn.ReadOnly = true;
            // 
            // Conc
            // 
            this.Conc.AppearanceHeader.Options.UseTextOptions = true;
            this.Conc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.Conc, "Conc");
            this.Conc.Columns.Add(this.AConcentration);
            this.Conc.Columns.Add(this.BConcentration);
            this.Conc.Columns.Add(this.CConcentration);
            this.Conc.Columns.Add(this.DConcentration);
            this.Conc.VisibleIndex = 5;
            // 
            // AConcentration
            // 
            this.AConcentration.AppearanceCell.Options.UseTextOptions = true;
            this.AConcentration.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.AConcentration, "AConcentration");
            this.AConcentration.FieldName = "AConcentration";
            this.AConcentration.MinWidth = 50;
            this.AConcentration.Name = "AConcentration";
            this.AConcentration.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // BConcentration
            // 
            this.BConcentration.AppearanceCell.Options.UseTextOptions = true;
            this.BConcentration.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.BConcentration, "BConcentration");
            this.BConcentration.FieldName = "BConcentration";
            this.BConcentration.MinWidth = 50;
            this.BConcentration.Name = "BConcentration";
            this.BConcentration.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // CConcentration
            // 
            this.CConcentration.AppearanceCell.Options.UseTextOptions = true;
            this.CConcentration.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.CConcentration, "CConcentration");
            this.CConcentration.FieldName = "CConcentration";
            this.CConcentration.MinWidth = 50;
            this.CConcentration.Name = "CConcentration";
            this.CConcentration.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // DConcentration
            // 
            this.DConcentration.AppearanceCell.Options.UseTextOptions = true;
            this.DConcentration.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            resources.ApplyResources(this.DConcentration, "DConcentration");
            this.DConcentration.FieldName = "DConcentration";
            this.DConcentration.MinWidth = 50;
            this.DConcentration.Name = "DConcentration";
            this.DConcentration.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // Unit
            // 
            this.Unit.AppearanceHeader.Options.UseTextOptions = true;
            this.Unit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.Unit, "Unit");
            this.Unit.Columns.Add(this.ChannelAUnit);
            this.Unit.Columns.Add(this.ChannelBUnit);
            this.Unit.Columns.Add(this.ChannelCUnit);
            this.Unit.Columns.Add(this.ChannelDUnit);
            this.Unit.VisibleIndex = 6;
            // 
            // ChannelAUnit
            // 
            this.ChannelAUnit.AppearanceCell.Options.UseTextOptions = true;
            this.ChannelAUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ChannelAUnit.AutoFillDown = true;
            resources.ApplyResources(this.ChannelAUnit, "ChannelAUnit");
            this.ChannelAUnit.ColumnEdit = this.rpCmbChannelUnit1;
            this.ChannelAUnit.FieldName = "ChannelAUnit";
            this.ChannelAUnit.Name = "ChannelAUnit";
            // 
            // rpCmbChannelUnit1
            // 
            resources.ApplyResources(this.rpCmbChannelUnit1, "rpCmbChannelUnit1");
            this.rpCmbChannelUnit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("rpCmbChannelUnit1.Buttons"))))});
            this.rpCmbChannelUnit1.Items.AddRange(new object[] {
            resources.GetString("rpCmbChannelUnit1.Items"),
            resources.GetString("rpCmbChannelUnit1.Items1"),
            resources.GetString("rpCmbChannelUnit1.Items2"),
            resources.GetString("rpCmbChannelUnit1.Items3"),
            resources.GetString("rpCmbChannelUnit1.Items4"),
            resources.GetString("rpCmbChannelUnit1.Items5"),
            resources.GetString("rpCmbChannelUnit1.Items6"),
            resources.GetString("rpCmbChannelUnit1.Items7")});
            this.rpCmbChannelUnit1.Name = "rpCmbChannelUnit1";
            // 
            // ChannelBUnit
            // 
            this.ChannelBUnit.AppearanceCell.Options.UseTextOptions = true;
            this.ChannelBUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.ChannelBUnit, "ChannelBUnit");
            this.ChannelBUnit.ColumnEdit = this.rpCmbChannelUnit2;
            this.ChannelBUnit.FieldName = "ChannelBUnit";
            this.ChannelBUnit.Name = "ChannelBUnit";
            // 
            // rpCmbChannelUnit2
            // 
            resources.ApplyResources(this.rpCmbChannelUnit2, "rpCmbChannelUnit2");
            this.rpCmbChannelUnit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("rpCmbChannelUnit2.Buttons"))))});
            this.rpCmbChannelUnit2.Items.AddRange(new object[] {
            resources.GetString("rpCmbChannelUnit2.Items"),
            resources.GetString("rpCmbChannelUnit2.Items1"),
            resources.GetString("rpCmbChannelUnit2.Items2"),
            resources.GetString("rpCmbChannelUnit2.Items3"),
            resources.GetString("rpCmbChannelUnit2.Items4"),
            resources.GetString("rpCmbChannelUnit2.Items5"),
            resources.GetString("rpCmbChannelUnit2.Items6"),
            resources.GetString("rpCmbChannelUnit2.Items7")});
            this.rpCmbChannelUnit2.Name = "rpCmbChannelUnit2";
            // 
            // ChannelCUnit
            // 
            this.ChannelCUnit.AppearanceCell.Options.UseTextOptions = true;
            this.ChannelCUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.ChannelCUnit, "ChannelCUnit");
            this.ChannelCUnit.ColumnEdit = this.rpCmbChannelUnit3;
            this.ChannelCUnit.FieldName = "ChannelCUnit";
            this.ChannelCUnit.Name = "ChannelCUnit";
            // 
            // rpCmbChannelUnit3
            // 
            resources.ApplyResources(this.rpCmbChannelUnit3, "rpCmbChannelUnit3");
            this.rpCmbChannelUnit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("rpCmbChannelUnit3.Buttons"))))});
            this.rpCmbChannelUnit3.Items.AddRange(new object[] {
            resources.GetString("rpCmbChannelUnit3.Items"),
            resources.GetString("rpCmbChannelUnit3.Items1"),
            resources.GetString("rpCmbChannelUnit3.Items2"),
            resources.GetString("rpCmbChannelUnit3.Items3"),
            resources.GetString("rpCmbChannelUnit3.Items4"),
            resources.GetString("rpCmbChannelUnit3.Items5"),
            resources.GetString("rpCmbChannelUnit3.Items6"),
            resources.GetString("rpCmbChannelUnit3.Items7")});
            this.rpCmbChannelUnit3.Name = "rpCmbChannelUnit3";
            // 
            // ChannelDUnit
            // 
            this.ChannelDUnit.AppearanceCell.Options.UseTextOptions = true;
            this.ChannelDUnit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.ChannelDUnit, "ChannelDUnit");
            this.ChannelDUnit.ColumnEdit = this.rpCmbChannelUnit4;
            this.ChannelDUnit.FieldName = "ChannelDUnit";
            this.ChannelDUnit.Name = "ChannelDUnit";
            // 
            // rpCmbChannelUnit4
            // 
            resources.ApplyResources(this.rpCmbChannelUnit4, "rpCmbChannelUnit4");
            this.rpCmbChannelUnit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("rpCmbChannelUnit4.Buttons"))))});
            this.rpCmbChannelUnit4.Items.AddRange(new object[] {
            resources.GetString("rpCmbChannelUnit4.Items"),
            resources.GetString("rpCmbChannelUnit4.Items1"),
            resources.GetString("rpCmbChannelUnit4.Items2"),
            resources.GetString("rpCmbChannelUnit4.Items3"),
            resources.GetString("rpCmbChannelUnit4.Items4"),
            resources.GetString("rpCmbChannelUnit4.Items5"),
            resources.GetString("rpCmbChannelUnit4.Items6"),
            resources.GetString("rpCmbChannelUnit4.Items7")});
            this.rpCmbChannelUnit4.Name = "rpCmbChannelUnit4";
            // 
            // Dilution
            // 
            this.Dilution.AppearanceHeader.Options.UseTextOptions = true;
            this.Dilution.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.Dilution, "Dilution");
            this.Dilution.Columns.Add(this.DiluteFactor);
            this.Dilution.Columns.Add(this.DilutePowerA);
            this.Dilution.Columns.Add(this.DilutePowerB);
            this.Dilution.Columns.Add(this.DilutePowerC);
            this.Dilution.Columns.Add(this.DilutePowerD);
            this.Dilution.VisibleIndex = 7;
            // 
            // DiluteFactor
            // 
            this.DiluteFactor.AppearanceCell.Options.UseTextOptions = true;
            this.DiluteFactor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.DiluteFactor, "DiluteFactor");
            this.DiluteFactor.ColumnEdit = this.repositoryItemPopupContainerEdit1;
            this.DiluteFactor.FieldName = "DiluteFactor";
            this.DiluteFactor.Name = "DiluteFactor";
            // 
            // repositoryItemPopupContainerEdit1
            // 
            resources.ApplyResources(this.repositoryItemPopupContainerEdit1, "repositoryItemPopupContainerEdit1");
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemPopupContainerEdit1.Buttons"))))});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // DilutePowerA
            // 
            this.DilutePowerA.AppearanceCell.Options.UseTextOptions = true;
            this.DilutePowerA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.DilutePowerA, "DilutePowerA");
            this.DilutePowerA.FieldName = "DilutePowerA";
            this.DilutePowerA.Name = "DilutePowerA";
            // 
            // DilutePowerB
            // 
            this.DilutePowerB.AppearanceCell.Options.UseTextOptions = true;
            this.DilutePowerB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.DilutePowerB, "DilutePowerB");
            this.DilutePowerB.FieldName = "DilutePowerB";
            this.DilutePowerB.Name = "DilutePowerB";
            // 
            // DilutePowerC
            // 
            this.DilutePowerC.AppearanceCell.Options.UseTextOptions = true;
            this.DilutePowerC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.DilutePowerC, "DilutePowerC");
            this.DilutePowerC.FieldName = "DilutePowerC";
            this.DilutePowerC.Name = "DilutePowerC";
            // 
            // DilutePowerD
            // 
            this.DilutePowerD.AppearanceCell.Options.UseTextOptions = true;
            this.DilutePowerD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.DilutePowerD, "DilutePowerD");
            this.DilutePowerD.FieldName = "DilutePowerD";
            this.DilutePowerD.Name = "DilutePowerD";
            // 
            // CurveNo
            // 
            this.CurveNo.AppearanceHeader.Options.UseTextOptions = true;
            this.CurveNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.CurveNo, "CurveNo");
            this.CurveNo.Columns.Add(this.CurveA);
            this.CurveNo.Columns.Add(this.CurveB);
            this.CurveNo.Columns.Add(this.CurveC);
            this.CurveNo.Columns.Add(this.CurveD);
            this.CurveNo.VisibleIndex = 8;
            // 
            // CurveA
            // 
            this.CurveA.AppearanceCell.Options.UseTextOptions = true;
            this.CurveA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.CurveA, "CurveA");
            this.CurveA.FieldName = "CurveA";
            this.CurveA.Name = "CurveA";
            this.CurveA.OptionsColumn.AllowEdit = false;
            this.CurveA.OptionsColumn.AllowMove = false;
            this.CurveA.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // CurveB
            // 
            this.CurveB.AppearanceCell.Options.UseTextOptions = true;
            this.CurveB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.CurveB, "CurveB");
            this.CurveB.FieldName = "CurveB";
            this.CurveB.Name = "CurveB";
            this.CurveB.OptionsColumn.AllowEdit = false;
            this.CurveB.OptionsColumn.AllowMove = false;
            this.CurveB.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // CurveC
            // 
            this.CurveC.AppearanceCell.Options.UseTextOptions = true;
            this.CurveC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.CurveC, "CurveC");
            this.CurveC.FieldName = "CurveC";
            this.CurveC.Name = "CurveC";
            this.CurveC.OptionsColumn.AllowEdit = false;
            this.CurveC.OptionsColumn.AllowMove = false;
            this.CurveC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // CurveD
            // 
            this.CurveD.AppearanceCell.Options.UseTextOptions = true;
            this.CurveD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            resources.ApplyResources(this.CurveD, "CurveD");
            this.CurveD.FieldName = "CurveD";
            this.CurveD.Name = "CurveD";
            this.CurveD.OptionsColumn.AllowEdit = false;
            this.CurveD.OptionsColumn.AllowMove = false;
            this.CurveD.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox5);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grdSample);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SampleBlankType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCmbChannelUnit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCmbChannelUnit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCmbChannelUnit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpCmbChannelUnit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        [ActionMethod(TestType.SA12, false)]
        [ActionMethod(TestType.SA18, true)]
        public System.Windows.Forms.TextBox textBox1;
        [ActionMethod(TestType.SA12, false)]
        [ActionMethod(TestType.SA18, true)]
        public System.Windows.Forms.TextBox textBox2;
        [ActionMethod(TestType.SA12, false)]
        [ActionMethod(TestType.SA18, true)]
        public System.Windows.Forms.TextBox textBox3;
        [ActionMethod(TestType.SA12, false)]
        [ActionMethod(TestType.SA18, true)]
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        [ActionMethod(TestType.SA12, false)]
        [ActionMethod(TestType.SA18, true)]
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        [ActionMethod(TestType.SA12, false)]
        [ActionMethod(TestType.SA18, true)]
        public DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        [ActionMethod(TestType.SA12, false)]
        [ActionMethod(TestType.SA18, true)]
        public System.Windows.Forms.TextBox textBox4;
        private DevExpress.XtraGrid.GridControl grdSample;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gvSample;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand ChannelSample;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grdClmnID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn SequenceNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CheckStatus;
        [ActionMethod(TestType.SA12, false)]
        [ActionMethod(TestType.SA18, true)]
        public DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn SampleName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn SampleType;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn PositionNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn SampleBlank;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox SampleBlankType;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand ChannelA;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn APeakArea;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn APeakArea2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn AReferArea;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand ChannelB;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BPeakArea;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BPeakArea2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BReferArea;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand ChannelC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CPeakArea;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CPeakArea2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CReferArea;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand ChannelD;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DPeakArea;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DPeakArea2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DReferArea;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand Conc;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn AConcentration;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn BConcentration;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CConcentration;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DConcentration;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand Unit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ChannelAUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rpCmbChannelUnit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ChannelBUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rpCmbChannelUnit2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ChannelCUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rpCmbChannelUnit3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn ChannelDUnit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rpCmbChannelUnit4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand Dilution;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DiluteFactor;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DilutePowerA;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DilutePowerB;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DilutePowerC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn DilutePowerD;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand CurveNo;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CurveA;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CurveB;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CurveC;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn CurveD;
        [ActionMethod(TestType.SA12, false)]
        [ActionMethod(TestType.SA18, true)]
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox5;
    }
}

