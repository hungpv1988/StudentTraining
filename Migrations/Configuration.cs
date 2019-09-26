﻿namespace StudentMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StudentMVC.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentMVC.Models.StudentDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "StudentMVC.Models.StudentDBContext";
        }

        protected override void Seed(StudentMVC.Models.StudentDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // delete all data, except for __MigrationHistory
            context.Database.ExecuteSqlCommand("sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'");
            context.Database.ExecuteSqlCommand("sp_MSForEachTable 'IF OBJECT_ID(''?'') NOT IN (ISNULL(OBJECT_ID(''[dbo].[__MigrationHistory]''),0)) DELETE FROM ? '");
            context.Database.ExecuteSqlCommand("EXEC sp_MSForEachTable 'ALTER TABLE ? CHECK CONSTRAINT ALL'");

            // add test data
            context.Students.AddOrUpdate(
                new Student
                {
                    FirstName = "Kennith",
                    LastName = "Rusch",
                    DoB = DateTime.Parse("1987-12-11"),
                    //AvatarImage = "/Content/Images/boy.png"
                },
                new Student
                {
                    FirstName = "Raise",
                    LastName = "Padgett",
                    DoB = DateTime.Parse("1989-1-11"),
                    //AvatarImage = "/Content/Images/boy-1.png"
                },
                new Student
                {
                    FirstName = "Retha",
                    LastName = "Segars",
                    DoB = DateTime.Parse("1973-6-12"),
                    //AvatarImage = "/Content/Images/girl.png"
                },
                new Student
                {
                    FirstName = "Wilbert",
                    LastName = "Fava",
                    DoB = DateTime.Parse("1982-1-11"),
                    //AvatarImage = "/Content/Images/girl-1.png"
                },
                new Student
                {
                    FirstName = "Marleen",
                    LastName = "Bashir",
                    DoB = DateTime.Parse("1989-9-21"),
                    //AvatarImage = "/Content/Images/man.png"
                },
                new Student
                {
                    FirstName = "Marybeth",
                    LastName = "Graziano",
                    DoB = DateTime.Parse("1989-1-11"),
                    //AvatarImage = "/Content/Images/man-1.png"
                },
                new Student
                {
                    FirstName = "Misti",
                    LastName = "Witte",
                    DoB = DateTime.Parse("1989-1-11"),
                    //AvatarImage = "/Content/Images/man-2.png"
                }
            );
        }
    }
}
