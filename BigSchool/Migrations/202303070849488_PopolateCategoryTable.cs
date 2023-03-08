﻿namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Web.Mvc.Ajax;

    public partial class PopolateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into categories (id,name) values(1, 'Development')");
            Sql("insert into categories (id,name) values(2, 'Business')");
            Sql("insert into categories (id,name) values(3, 'Marketing')");
        }

        public override void Down()
        {
        }
    }
}
