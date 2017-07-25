namespace WindowsNavigator
{
    using System.Data.Entity;
    using System.Windows.Forms;
    using WindowsNavigator.Data;
    using WindowsNavigator.Models;

    public static class Program
    {
        public static void Main()
        {
            using (var db = new WindowsNavigatorDbContext())
            {
                if (!Database.Exists(@"Data Source=DESKTOP-52UDVT7\SQLEXPRESS;Initial Catalog=WindowsNavigatorConnString;Integrated Security=True"))
                {
                    var button = new ButtonProp(1, "test", "test", "test");

                    db.ButtonProp.Add(button);
                    db.SaveChanges();
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
