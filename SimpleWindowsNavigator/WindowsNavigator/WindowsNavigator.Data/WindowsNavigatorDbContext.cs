﻿namespace WindowsNavigator.Data
{
    using System.Data.Entity;
    using WindowsNavigator.Models;

    public class WindowsNavigatorDbContext : DbContext
    {
        public WindowsNavigatorDbContext() : base("WindowsNavigatorConnString")
        {

        }
        public DbSet<ButtonProp> ButtonProp { get; set; }
    }
}
