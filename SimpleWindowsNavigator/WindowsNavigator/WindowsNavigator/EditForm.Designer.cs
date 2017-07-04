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
            this.windowsNavigatorConnStringDataSet = new WindowsNavigator.WindowsNavigatorConnStringDataSet();
            this.windowsNavigatorConnStringDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPropsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPropsTableAdapter1 = new WindowsNavigator.WindowsNavigatorConnStringDataSetTableAdapters.ButtonPropsTableAdapter();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsNavigatorConnStringDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsNavigatorConnStringDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPropsBindingSource1)).BeginInit();
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
            this.ButtonsGridView.DataSource = this.buttonPropsBindingSource1;
            this.ButtonsGridView.Location = new System.Drawing.Point(102, 127);
            this.ButtonsGridView.Name = "ButtonsGridView";
            this.ButtonsGridView.RowTemplate.Height = 24;
            this.ButtonsGridView.Size = new System.Drawing.Size(798, 224);
            this.ButtonsGridView.TabIndex = 0;
            this.ButtonsGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ButtonsGridView_CellEndEdit);
            // 
            // windowsNavigatorConnStringDataSet
            // 
            this.windowsNavigatorConnStringDataSet.DataSetName = "WindowsNavigatorConnStringDataSet";
            this.windowsNavigatorConnStringDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // windowsNavigatorConnStringDataSetBindingSource
            // 
            this.windowsNavigatorConnStringDataSetBindingSource.DataSource = this.windowsNavigatorConnStringDataSet;
            this.windowsNavigatorConnStringDataSetBindingSource.Position = 0;
            // 
            // buttonPropsBindingSource1
            // 
            this.buttonPropsBindingSource1.DataMember = "ButtonProps";
            this.buttonPropsBindingSource1.DataSource = this.windowsNavigatorConnStringDataSet;
            // 
            // buttonPropsTableAdapter1
            // 
            this.buttonPropsTableAdapter1.ClearBeforeFill = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Button Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Button URL/Path";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            this.linkDataGridViewTextBoxColumn.Width = 350;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "ButtonColor from argb";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.windowsNavigatorConnStringDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsNavigatorConnStringDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPropsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ButtonsGridView;
        private System.Windows.Forms.BindingSource windowsNavigatorConnStringDataSetBindingSource;
        private WindowsNavigatorConnStringDataSet windowsNavigatorConnStringDataSet;
        private System.Windows.Forms.BindingSource buttonPropsBindingSource1;
        private WindowsNavigatorConnStringDataSetTableAdapters.ButtonPropsTableAdapter buttonPropsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
    }
}