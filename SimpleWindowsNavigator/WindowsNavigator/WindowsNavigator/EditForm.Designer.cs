namespace WindowsNavigator
{
    partial class EditForm
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
            this.ButtonsGridView = new System.Windows.Forms.DataGridView();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPropsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.windowsNavigatorDataWindowsNavigatorDbContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._WindowsNavigator_Data_WindowsNavigatorDbContextDataSet = new WindowsNavigator._WindowsNavigator_Data_WindowsNavigatorDbContextDataSet();
            this.buttonPropsTableAdapter = new WindowsNavigator._WindowsNavigator_Data_WindowsNavigatorDbContextDataSetTableAdapters.ButtonPropsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPropsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsNavigatorDataWindowsNavigatorDbContextDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._WindowsNavigator_Data_WindowsNavigatorDbContextDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonsGridView
            // 
            this.ButtonsGridView.AllowUserToAddRows = false;
            this.ButtonsGridView.AllowUserToDeleteRows = false;
            this.ButtonsGridView.AutoGenerateColumns = false;
            this.ButtonsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ButtonsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
            this.ButtonsGridView.DataSource = this.buttonPropsBindingSource;
            this.ButtonsGridView.Location = new System.Drawing.Point(102, 127);
            this.ButtonsGridView.Name = "ButtonsGridView";
            this.ButtonsGridView.RowTemplate.Height = 24;
            this.ButtonsGridView.Size = new System.Drawing.Size(798, 224);
            this.ButtonsGridView.TabIndex = 0;
            this.ButtonsGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ButtonsGridView_CellEndEdit);
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Button name";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.FillWeight = 200F;
            this.linkDataGridViewTextBoxColumn.HeaderText = "URL";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            this.linkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.linkDataGridViewTextBoxColumn.Width = 350;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color From Argb";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buttonPropsBindingSource
            // 
            this.buttonPropsBindingSource.DataMember = "ButtonProps";
            this.buttonPropsBindingSource.DataSource = this.windowsNavigatorDataWindowsNavigatorDbContextDataSetBindingSource;
            // 
            // windowsNavigatorDataWindowsNavigatorDbContextDataSetBindingSource
            // 
            this.windowsNavigatorDataWindowsNavigatorDbContextDataSetBindingSource.DataSource = this._WindowsNavigator_Data_WindowsNavigatorDbContextDataSet;
            this.windowsNavigatorDataWindowsNavigatorDbContextDataSetBindingSource.Position = 0;
            // 
            // _WindowsNavigator_Data_WindowsNavigatorDbContextDataSet
            // 
            this._WindowsNavigator_Data_WindowsNavigatorDbContextDataSet.DataSetName = "_WindowsNavigator_Data_WindowsNavigatorDbContextDataSet";
            this._WindowsNavigator_Data_WindowsNavigatorDbContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPropsTableAdapter
            // 
            this.buttonPropsTableAdapter.ClearBeforeFill = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsNavigator.Properties.Resources.tasklist;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(986, 555);
            this.Controls.Add(this.ButtonsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditForm_FormClosed);
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPropsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsNavigatorDataWindowsNavigatorDbContextDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._WindowsNavigator_Data_WindowsNavigatorDbContextDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ButtonsGridView;
        private System.Windows.Forms.BindingSource windowsNavigatorDataWindowsNavigatorDbContextDataSetBindingSource;
        private _WindowsNavigator_Data_WindowsNavigatorDbContextDataSet _WindowsNavigator_Data_WindowsNavigatorDbContextDataSet;
        private System.Windows.Forms.BindingSource buttonPropsBindingSource;
        private _WindowsNavigator_Data_WindowsNavigatorDbContextDataSetTableAdapters.ButtonPropsTableAdapter buttonPropsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
    }
}