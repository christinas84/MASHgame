namespace MASHgame.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MASHgame.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MASHgame.Models.ApplicationDbContext context)
        {
            //var question = new List<Question>
            //{
            //    new Question {Description = "Where do you want to live?" },
            //    new Question {Description = "Your future profession?" },
            //    new Question {Description = "Your future car?" },
            //    new Question {Description = "Who will you marry?" },
            //    new Question {Description = "Future pet?" },
            //    new Question {Description = "How many kids will you have?" }
            //};
            
            //question.ForEach(q => context.Questions.Add(q));
            //context.SaveChanges();
        }
    }
}
