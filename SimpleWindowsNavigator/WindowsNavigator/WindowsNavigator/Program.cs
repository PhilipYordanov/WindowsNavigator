namespace WindowsNavigator
{
    using System.Data.Entity;
    using System.Windows.Forms;
    using WindowsNavigator.Models;

    public static class Program
    {
        public static void Main()
        {
            using (var dbContext = new _WindowsNavigator_Data_WindowsNavigatorDbContextDataSet())
            {
                if (!Database.Exists(@"Data Source=DESKTOP-52UDVT7\SQLEXPRESS;Initial Catalog=WindowsNavigator.Data.WindowsNavigatorDbContext;Integrated Security=True"))
                {
                    var test = new ButtonProp(1, "Test", "Test", "Test");
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
