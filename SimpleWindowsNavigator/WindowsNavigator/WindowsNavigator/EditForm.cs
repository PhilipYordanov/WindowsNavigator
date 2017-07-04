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
           this.buttonPropsTableAdapter1.Fill(this.windowsNavigatorConnStringDataSet.ButtonProps);
        }

        private void ButtonsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Validate();
                this.buttonPropsBindingSource1.EndEdit();
                this.buttonPropsTableAdapter1.Update(this.windowsNavigatorConnStringDataSet.ButtonProps);
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
