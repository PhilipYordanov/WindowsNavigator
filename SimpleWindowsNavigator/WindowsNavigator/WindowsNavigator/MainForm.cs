namespace WindowsNavigator
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Linq;
    using System.Net;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using WindowsNavigator.Models;

    public partial class MainForm : Form
    {
        private List<ButtonProp> listOfButtonsFromDb = new List<ButtonProp>();

        public List<ButtonProp> ListOfButtonsFromDb
        {
            get
            {
                return this.listOfButtonsFromDb;
            }

            set
            {
                this.listOfButtonsFromDb = value;
            }
        }

        public MainForm()
        {
            this.InitializeComponent();

            // TODO: Ask Value if that's the right way to extract data from DbContext
            // read data from Database
            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-52UDVT7\SQLEXPRESS;
                                       Initial Catalog=WindowsNavigator.Data.WindowsNavigatorDbContext;
                                       Integrated Security=True"))
            {
                sqlConn.Open();
                var query = "SELECT * FROM ButtonProps";
                var executeQuery = new SqlCommand(query, sqlConn);
                var data = executeQuery.ExecuteReader();
                while (data.Read())
                {
                    var id = Convert.ToInt32(data[0]);
                    var text = Convert.ToString(data[1]);
                    var link = Convert.ToString(data[2]);
                    var color = Convert.ToString(data[3]);
                    var currentButton = new ButtonProp(id, text, link, color);
                    this.listOfButtonsFromDb.Add(currentButton);
                }

                sqlConn.Close();
            }

            // implement properties for each button
            this.FirstButton(this.listOfButtonsFromDb);
            this.SecondButton(this.listOfButtonsFromDb);
            this.ThirdButton(this.listOfButtonsFromDb);
            this.ForthButton(this.listOfButtonsFromDb);
            this.FifthButton(this.listOfButtonsFromDb);
            this.SixtButton(this.listOfButtonsFromDb);
        }

        private void SixtButton(List<ButtonProp> listOfButtonsFromDb)
        {
            this.VisualStudio2017.Text = $"{this.listOfButtonsFromDb[5].Text}";
            var colorTokens = this.listOfButtonsFromDb[5]
                .Color
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            this.VisualStudio2017.BackColor = System.Drawing.Color.FromArgb((byte)colorTokens[0], (byte)colorTokens[1], (byte)colorTokens[2]);
        }

        private void FifthButton(List<ButtonProp> listOfButtonsFromDb)
        {
            this.HackerRank.Text = $"{this.listOfButtonsFromDb[4].Text}";
            var colorTokens = this.listOfButtonsFromDb[4]
                .Color
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            this.HackerRank.BackColor = System.Drawing.Color.FromArgb((byte)colorTokens[0], (byte)colorTokens[1], (byte)colorTokens[2]);
        }

        private void ForthButton(List<ButtonProp> listOfButtonsFromDb)
        {
            this.GitHub.Text = $"{this.listOfButtonsFromDb[3].Text}";
            var colorTokens = this.listOfButtonsFromDb[3]
                .Color
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            this.GitHub.BackColor = System.Drawing.Color.FromArgb((byte)colorTokens[0], (byte)colorTokens[1], (byte)colorTokens[2]);
        }

        private void ThirdButton(List<ButtonProp> listOfButtonsFromDb)
        {
            this.JSButton.Text = $"{this.listOfButtonsFromDb[2].Text}";
            var colorTokens = this.listOfButtonsFromDb[2]
                .Color
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            this.JSButton.BackColor = System.Drawing.Color.FromArgb((byte)colorTokens[0], (byte)colorTokens[1], (byte)colorTokens[2]);

        }

        private void SecondButton(List<ButtonProp> listOfButtonsFromDb)
        {
            this.Judge.Text = $"{this.listOfButtonsFromDb[1].Text}";
            var colorTokens = this.listOfButtonsFromDb[1]
                .Color
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            this.Judge.BackColor = System.Drawing.Color.FromArgb((byte)colorTokens[0], (byte)colorTokens[1], (byte)colorTokens[2]);
        }

        private void FirstButton(List<ButtonProp> listOfButtonsFromDb)
        {
            this.SoftUni.Text = $"{this.listOfButtonsFromDb[0].Text}";
            if (this.SoftUni.Text == string.Empty)
            {
                this.SoftUni.Visible = false;
            }

            var colorTokens = this.listOfButtonsFromDb[0]
                .Color
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            this.SoftUni.BackColor = System.Drawing.Color.FromArgb((byte)colorTokens[0], (byte)colorTokens[1], (byte)colorTokens[2]);
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
        }

        // buttons
        public void SoftUni_Click(object sender, EventArgs e)
        {
            try
            {
                var path = this.listOfButtonsFromDb[0].Link;
                var pattern = @"[https]+:\/\/";
                var match = Regex.IsMatch(path, pattern);
                if (match)
                {
                    using (var client = new WebClient())
                    {
                        using (var stream = client.OpenRead(path))
                        {
                            Process.Start("chrome.exe", this.listOfButtonsFromDb[0].Link);
                        }
                    }
                }
                else
                {
                    ProcessStartInfo buttonThreePath = new ProcessStartInfo();
                    buttonThreePath.FileName = path;
                    Process.Start(buttonThreePath);
                }
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        public void Judge_Click(object sender, EventArgs e)
        {
            try
            {
                var path = this.listOfButtonsFromDb[1].Link;
                var pattern = @"[https]+:\/\/";
                var match = Regex.IsMatch(path, pattern);
                if (match)
                {
                    using (var client = new WebClient())
                    {
                        using (var stream = client.OpenRead(path))
                        {
                            Process.Start("chrome.exe", path);
                        }
                    }
                }
                else
                {
                    ProcessStartInfo buttonThreePath = new ProcessStartInfo();
                    buttonThreePath.FileName = path;
                    Process.Start(buttonThreePath);
                }
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        public void VisualStudio2017_Click(object sender, EventArgs e)
        {
            try
            {
                var path = this.listOfButtonsFromDb[5].Link;
                var pattern = @"[https]+:\/\/";
                var match = Regex.IsMatch(path, pattern);
                if (match)
                {
                    using (var client = new WebClient())
                    {
                        using (var stream = client.OpenRead(path))
                        {
                            Process.Start("chrome.exe", path);
                        }
                    }
                }
                else
                {
                    ProcessStartInfo buttonThreePath = new ProcessStartInfo();
                    buttonThreePath.FileName = path;
                    Process.Start(buttonThreePath);
                }
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        public void HackerRank_Click(object sender, EventArgs e)
        {
            try
            {
                var path = this.listOfButtonsFromDb[4].Link;
                var pattern = @"[https]+:\/\/";
                var match = Regex.IsMatch(path, pattern);
                if (match)
                {
                    using (var client = new WebClient())
                    {
                        using (var stream = client.OpenRead(path))
                        {
                            Process.Start("chrome.exe", path);
                        }
                    }
                }
                else
                {
                    ProcessStartInfo buttonThreePath = new ProcessStartInfo();
                    buttonThreePath.FileName = path;
                    Process.Start(buttonThreePath);
                }
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        public void GitHub_Click(object sender, EventArgs e)
        {
            try
            {
                var path = this.listOfButtonsFromDb[3].Link;
                var pattern = @"[https]+:\/\/";
                var match = Regex.IsMatch(path, pattern);
                if (match)
                {
                    using (var client = new WebClient())
                    {
                        using (var stream = client.OpenRead(path))
                        {
                            Process.Start("chrome.exe", path);
                        }
                    }
                }
                else
                {
                    ProcessStartInfo buttonThreePath = new ProcessStartInfo();
                    buttonThreePath.FileName = path;
                    Process.Start(buttonThreePath);
                }
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        private static void ErrorMessage()
        {
            MessageBox.Show("There is no Internet connection", "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void JSButton_Click(object sender, EventArgs e)
        {
            try
            {
                var path = this.listOfButtonsFromDb[2].Link;
                var pattern = @"[https]+:\/\/";
                var match = Regex.IsMatch(path, pattern);
                if (match)
                {
                    using (var client = new WebClient())
                    {
                        using (var stream = client.OpenRead(this.listOfButtonsFromDb[2].Link))
                        {
                            Process.Start("chrome.exe", this.listOfButtonsFromDb[2].Link);
                        }
                    }
                }
                else
                {
                    ProcessStartInfo buttonThreePath = new ProcessStartInfo();
                    buttonThreePath.FileName = path;
                    Process.Start(buttonThreePath);
                }
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var edit = new EditForm(this);
            edit.ShowDialog();
            this.Close();
        }
    }
}
