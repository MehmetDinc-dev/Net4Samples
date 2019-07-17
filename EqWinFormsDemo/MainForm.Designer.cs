﻿namespace EqWinFormsDemo
{
    partial class MainForm
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
            if (disposing && (components != null)) {
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager("EqWinFormsDemo.MainForm.Resources",
                typeof(MainForm).Assembly); 

            this.ResultDataTable = new System.Data.DataTable();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.ResultDS = new System.Data.DataSet();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelExport = new System.Windows.Forms.GroupBox();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.btnExportExel = new System.Windows.Forms.Button();
            this.groupBoxResultSet = new System.Windows.Forms.GroupBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxSQL = new System.Windows.Forms.GroupBox();
            this.teSQL = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelBG = new System.Windows.Forms.Panel();
            this.groupBoxEntities = new System.Windows.Forms.GroupBox();
            this.EntPanel = new Korzh.EasyQuery.WinForms.EntitiesPanel();
            this.panelQuery = new System.Windows.Forms.Panel();
            this.groupBoxColumns = new System.Windows.Forms.GroupBox();
            this.QCPanel = new Korzh.EasyQuery.WinForms.QueryColumnsPanel();
            this.groupBoxConditions = new System.Windows.Forms.GroupBox();
            this.QPanel = new Korzh.EasyQuery.WinForms.QueryPanel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panelColumns = new System.Windows.Forms.Panel();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.groupBoxSorting = new System.Windows.Forms.GroupBox();
            this.SCPanel = new Korzh.EasyQuery.WinForms.SortColumnsPanel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btClear = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btExecute = new System.Windows.Forms.Button();
            this.toolTipExel = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCsv = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDS)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelExport.SuspendLayout();
            this.groupBoxResultSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBoxSQL.SuspendLayout();
            this.panelBG.SuspendLayout();
            this.groupBoxEntities.SuspendLayout();
            this.panelQuery.SuspendLayout();
            this.groupBoxColumns.SuspendLayout();
            this.groupBoxConditions.SuspendLayout();
            this.panelColumns.SuspendLayout();
            this.groupBoxSorting.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            this.dataModel1 = new Korzh.EasyQuery.Db.DbModel();
            this.query1 = new Korzh.EasyQuery.Db.DbQuery(this.dataModel1);
            // 
            // dataModel1
            // 
            this.dataModel1.CustomInfo = "";
            this.dataModel1.DefQueryFilePath = "";
            this.dataModel1.Description = null;
            this.dataModel1.EntityContainerName = "";
            this.dataModel1.ID = "25704bf3-5f67-4ad8-8be8-bb1b47a3073e";
            this.dataModel1.IsLoadedFromDbContext = false;
            this.dataModel1.Name = null;
            this.dataModel1.ProgressIndicator = null;
            this.dataModel1.StoreDbParams = false;
            // 
            // query1
            // 
            this.query1.ExtraColumns = "";
            this.query1.ID = "7aae5709-c310-452e-b605-087fd2055ca3";
            this.query1.Model = this.dataModel1;
            this.query1.NoPathResolution = Korzh.EasyQuery.NoPathResolution.ThrowException;
            this.query1.Name = "SampleQuery";
            this.query1.SyncColSortOrder = true;
            this.query1.ColumnsChanged += new Korzh.EasyQuery.ColumnsChangedEventHandler(this.query1_ColumnsChanged);
            this.query1.ConditionsChanged += new Korzh.EasyQuery.ConditionsChangedEventHandler(this.query1_ConditionsChanged);
            // 
            // ResultDataTable
            // 
            this.ResultDataTable.TableName = "Result";
            // 
            // ResultDS
            // 
            this.ResultDS.DataSetName = "ResultDataSet";
            this.ResultDS.Locale = new System.Globalization.CultureInfo("en");
            this.ResultDS.Tables.AddRange(new System.Data.DataTable[] {
            this.ResultDataTable});
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelExport);
            this.panelBottom.Controls.Add(this.groupBoxResultSet);
            this.panelBottom.Controls.Add(this.splitter1);
            this.panelBottom.Controls.Add(this.groupBoxSQL);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 382);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(920, 178);
            this.panelBottom.TabIndex = 23;
            // 
            // panelExport
            // 
            this.panelExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExport.Controls.Add(this.btnExportCsv);
            this.panelExport.Controls.Add(this.btnExportExel);
            this.panelExport.Location = new System.Drawing.Point(887, 0);
            this.panelExport.Name = "panelExport";
            this.panelExport.Size = new System.Drawing.Size(33, 178);
            this.panelExport.TabIndex = 2;
            this.panelExport.TabStop = false;
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Image = ((System.Drawing.Image)(resources.GetObject("btnExportCsv.Image")));
            this.btnExportCsv.Location = new System.Drawing.Point(2, 51);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(28, 28);
            this.btnExportCsv.TabIndex = 1;
            this.btnExportCsv.Tag = "";
            this.toolTipCsv.SetToolTip(this.btnExportCsv, "Export to CSV");
            this.btnExportCsv.UseVisualStyleBackColor = true;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // btnExportExel
            // 
            this.btnExportExel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExel.Image")));
            this.btnExportExel.Location = new System.Drawing.Point(2, 16);
            this.btnExportExel.Name = "btnExportExel";
            this.btnExportExel.Size = new System.Drawing.Size(28, 28);
            this.btnExportExel.TabIndex = 0;
            this.btnExportExel.Tag = "";
            this.toolTipExel.SetToolTip(this.btnExportExel, "Export to Excel");
            this.btnExportExel.UseVisualStyleBackColor = true;
            this.btnExportExel.Click += new System.EventHandler(this.btnExportXls_Click);
            // 
            // groupBoxResultSet
            // 
            this.groupBoxResultSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResultSet.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxResultSet.Controls.Add(this.dataGrid1);
            this.groupBoxResultSet.Location = new System.Drawing.Point(365, 0);
            this.groupBoxResultSet.Name = "groupBoxResultSet";
            this.groupBoxResultSet.Size = new System.Drawing.Size(518, 172);
            this.groupBoxResultSet.TabIndex = 2;
            this.groupBoxResultSet.TabStop = false;
            this.groupBoxResultSet.Text = "Result set";
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.DataSource = this.ResultDataTable;
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(3, 16);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(514, 154);
            this.dataGrid1.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(359, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 178);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // groupBoxSQL
            // 
            this.groupBoxSQL.Controls.Add(this.teSQL);
            this.groupBoxSQL.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxSQL.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSQL.Name = "groupBoxSQL";
            this.groupBoxSQL.Size = new System.Drawing.Size(359, 178);
            this.groupBoxSQL.TabIndex = 0;
            this.groupBoxSQL.TabStop = false;
            this.groupBoxSQL.Text = "SQL";
            // 
            // teSQL
            // 
            this.teSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teSQL.Location = new System.Drawing.Point(8, 16);
            this.teSQL.Multiline = true;
            this.teSQL.Name = "teSQL";
            this.teSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.teSQL.Size = new System.Drawing.Size(343, 154);
            this.teSQL.TabIndex = 9;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 379);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(920, 3);
            this.splitter2.TabIndex = 24;
            this.splitter2.TabStop = false;
            // 
            // panelBG
            // 
            this.panelBG.Controls.Add(this.groupBoxEntities);
            this.panelBG.Controls.Add(this.panelQuery);
            this.panelBG.Controls.Add(this.panelButtons);
            this.panelBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBG.Location = new System.Drawing.Point(0, 0);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(920, 379);
            this.panelBG.TabIndex = 25;
            // 
            // groupBoxEntities
            // 
            this.groupBoxEntities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxEntities.Controls.Add(this.EntPanel);
            this.groupBoxEntities.Location = new System.Drawing.Point(3, 44);
            this.groupBoxEntities.Name = "groupBoxEntities";
            this.groupBoxEntities.Size = new System.Drawing.Size(179, 335);
            this.groupBoxEntities.TabIndex = 29;
            this.groupBoxEntities.TabStop = false;
            this.groupBoxEntities.Text = "Objects and their attributes";
            // 
            // EntPanel
            // 
            this.EntPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EntPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EntPanel.ImageAddColumns = ((System.Drawing.Image)(resources.GetObject("EntPanel.ImageAddColumns")));
            this.EntPanel.ImageAddConditions = ((System.Drawing.Image)(resources.GetObject("EntPanel.ImageAddConditions")));
            this.EntPanel.ImageSelectAll = ((System.Drawing.Image)(resources.GetObject("EntPanel.ImageSelectAll")));
            this.EntPanel.ImageSelectNone = ((System.Drawing.Image)(resources.GetObject("EntPanel.ImageSelectNone")));
            this.EntPanel.Location = new System.Drawing.Point(3, 19);
            this.EntPanel.Name = "EntPanel";
            this.EntPanel.Query = this.query1;
            this.EntPanel.ShowFilter = true;
            this.EntPanel.Size = new System.Drawing.Size(173, 310);
            this.EntPanel.TabIndex = 29;
            // 
            // panelQuery
            // 
            this.panelQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuery.Controls.Add(this.groupBoxColumns);
            this.panelQuery.Controls.Add(this.groupBoxConditions);
            this.panelQuery.Controls.Add(this.splitter3);
            this.panelQuery.Controls.Add(this.panelColumns);
            this.panelQuery.Location = new System.Drawing.Point(185, 41);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(651, 338);
            this.panelQuery.TabIndex = 23;
            // 
            // groupBoxColumns
            // 
            this.groupBoxColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxColumns.Controls.Add(this.QCPanel);
            this.groupBoxColumns.Location = new System.Drawing.Point(0, 3);
            this.groupBoxColumns.Name = "groupBoxColumns";
            this.groupBoxColumns.Size = new System.Drawing.Size(414, 142);
            this.groupBoxColumns.TabIndex = 33;
            this.groupBoxColumns.TabStop = false;
            this.groupBoxColumns.Text = "Query Columns";
            // 
            // QCPanel
            // 
            this.QCPanel.Active = true;
            this.QCPanel.ActiveRowIndex = -1;
            this.QCPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QCPanel.Appearance.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(190)))));
            this.QCPanel.Appearance.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.QCPanel.Appearance.AdditionRowColor = System.Drawing.Color.DarkGreen;
            this.QCPanel.Appearance.AttrElementFormat = "{entity} {attr}";
            this.QCPanel.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.QCPanel.Appearance.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.QCPanel.Appearance.ButtonMacStyle = false;
            this.QCPanel.Appearance.FocusBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QCPanel.Appearance.Title = "";
            this.QCPanel.BackColor = System.Drawing.Color.LightYellow;
            this.QCPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QCPanel.EditMode = Korzh.EasyQuery.WinForms.QueryColumnsPanel.EditModeKind.All;
            this.QCPanel.Location = new System.Drawing.Point(7, 18);
            this.QCPanel.Name = "QCPanel";
            this.QCPanel.Query = this.query1;
            this.QCPanel.Size = new System.Drawing.Size(402, 118);
            this.QCPanel.TabIndex = 27;
            this.QCPanel.TabStop = true;
            // 
            // groupBoxConditions
            // 
            this.groupBoxConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConditions.Controls.Add(this.QPanel);
            this.groupBoxConditions.Location = new System.Drawing.Point(0, 145);
            this.groupBoxConditions.Name = "groupBoxConditions";
            this.groupBoxConditions.Size = new System.Drawing.Size(648, 193);
            this.groupBoxConditions.TabIndex = 2;
            this.groupBoxConditions.TabStop = false;
            this.groupBoxConditions.Text = "Query Conditions";
            // 
            // QPanel
            // 
            this.QPanel.Active = true;
            this.QPanel.ActiveRowIndex = 0;
            this.QPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QPanel.Appearance.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(190)))));
            this.QPanel.Appearance.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.QPanel.Appearance.AdditionRowColor = System.Drawing.Color.DarkGreen;
            this.QPanel.Appearance.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.QPanel.Appearance.ButtonMacStyle = false;
            this.QPanel.Appearance.DefaultListControlType = "LISTBOX";
            this.QPanel.Appearance.ExprColor = System.Drawing.Color.Indigo;
            this.QPanel.Appearance.FocusBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QPanel.Appearance.OperatorColor = System.Drawing.Color.MediumBlue;
            this.QPanel.Appearance.ShowRootRow = true;
            this.QPanel.BackColor = System.Drawing.Color.White;
            this.QPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QPanel.Location = new System.Drawing.Point(7, 14);
            this.QPanel.Name = "QPanel";

            this.QPanel.Size = new System.Drawing.Size(635, 176);
            this.QPanel.TabIndex = 27;
            this.QPanel.TabStop = true;
            this.QPanel.ListRequest += new Korzh.EasyQuery.WinForms.ListRequestEventHandler(this.QPanel_ListRequest);
            this.QPanel.ValueRequest += new Korzh.EasyQuery.WinForms.ValueRequestEventHandler(this.QPanel_ValueRequest);
            this.QPanel.ConditionRender += new Korzh.EasyQuery.WinForms.ConditionRenderEventHandler(this.QPanel_ConditionRender);
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(651, 3);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // panelColumns
            // 
            this.panelColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColumns.Controls.Add(this.splitter4);
            this.panelColumns.Controls.Add(this.groupBoxSorting);
            this.panelColumns.Location = new System.Drawing.Point(4, 3);
            this.panelColumns.Name = "panelColumns";
            this.panelColumns.Size = new System.Drawing.Size(647, 142);
            this.panelColumns.TabIndex = 4;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(0, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 142);
            this.splitter4.TabIndex = 31;
            this.splitter4.TabStop = false;
            // 
            // groupBoxSorting
            // 
            this.groupBoxSorting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSorting.Controls.Add(this.SCPanel);
            this.groupBoxSorting.Location = new System.Drawing.Point(410, 0);
            this.groupBoxSorting.Name = "groupBoxSorting";
            this.groupBoxSorting.Size = new System.Drawing.Size(234, 142);
            this.groupBoxSorting.TabIndex = 30;
            this.groupBoxSorting.TabStop = false;
            this.groupBoxSorting.Text = "Columns Sorting";
            // 
            // SCPanel
            // 
            this.SCPanel.Active = true;
            this.SCPanel.ActiveRowIndex = -1;
            this.SCPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SCPanel.Appearance.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(225)))), ((int)(((byte)(190)))));
            this.SCPanel.Appearance.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.SCPanel.Appearance.AdditionRowColor = System.Drawing.Color.DarkGreen;
            this.SCPanel.Appearance.AttrElementFormat = "{entity} {attr}";
            this.SCPanel.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.SCPanel.Appearance.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.SCPanel.Appearance.ButtonMacStyle = false;
            this.SCPanel.Appearance.FocusBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SCPanel.Appearance.Title = "";
            this.SCPanel.BackColor = System.Drawing.Color.LightYellow;
            this.SCPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SCPanel.EditMode = Korzh.EasyQuery.WinForms.QueryColumnsPanel.EditModeKind.All;
            this.SCPanel.Location = new System.Drawing.Point(6, 18);
            this.SCPanel.Name = "SCPanel";
            this.SCPanel.Query = this.query1;
            this.SCPanel.Size = new System.Drawing.Size(222, 118);
            this.SCPanel.SortEditMode = Korzh.EasyQuery.WinForms.SortColumnsPanel.SortEditModeKind.All;
            this.SCPanel.TabIndex = 28;
            this.SCPanel.TabStop = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.Controls.Add(this.btClear);
            this.panelButtons.Controls.Add(this.btLoad);
            this.panelButtons.Controls.Add(this.btSave);
            this.panelButtons.Controls.Add(this.btExecute);
            this.panelButtons.Location = new System.Drawing.Point(842, 38);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(78, 323);
            this.panelButtons.TabIndex = 22;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(8, 16);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(62, 24);
            this.btClear.TabIndex = 12;
            this.btClear.Text = "Clear";
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(8, 56);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(62, 24);
            this.btLoad.TabIndex = 11;
            this.btLoad.Text = "Load";
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(8, 88);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(62, 24);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(8, 162);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(62, 39);
            this.btExecute.TabIndex = 9;
            this.btExecute.Text = "Execute Query";
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 560);
            this.Controls.Add(this.panelBG);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panelBottom);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Query.NET WinForms demo";
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDS)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelExport.ResumeLayout(false);
            this.groupBoxResultSet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBoxSQL.ResumeLayout(false);
            this.groupBoxSQL.PerformLayout();
            this.panelBG.ResumeLayout(false);
            this.panelBG.PerformLayout();
            this.groupBoxEntities.ResumeLayout(false);
            this.panelQuery.ResumeLayout(false);
            this.groupBoxColumns.ResumeLayout(false);
            this.groupBoxConditions.ResumeLayout(false);
            this.panelColumns.ResumeLayout(false);
            this.groupBoxSorting.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
