namespace WindowsNavigator
{
    using System;
    using System.Windows.Forms;

    public partial class EditForm : Form
    {
        public EditForm()
        {
            this.InitializeComponent();
        }

        private Form mainForm;

        public EditForm(MainForm mainForm)
        {
            this.InitializeComponent();
            this.mainForm = mainForm;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            this.buttonPropsTableAdapter.Fill(this._WindowsNavigator_Data_WindowsNavigatorDbContextDataSet.ButtonProps);
        }

        private void ButtonsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Validate();
                this.buttonPropsBindingSource.EndEdit();
                this.buttonPropsTableAdapter.Update(this._WindowsNavigator_Data_WindowsNavigatorDbContextDataSet.ButtonProps);
                MessageBox.Show("updates were made successful", "Update Info");
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing went wrong....");
            }
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            var main = new MainForm();
            main.ShowDialog();
            this.Close();
        }
    }
}
