namespace GetAnswer.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GetAnswer.Model.GetAnswerModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

        }

        protected override void Seed(GetAnswer.Model.GetAnswerModel context)
        {
 
        }
    }
}
