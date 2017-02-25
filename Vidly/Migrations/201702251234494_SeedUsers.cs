namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'00bb7a77-b608-4035-90a1-3e9140ea5be0', N'quest@vidly.com', 0, N'AN4DwP+BUuJW1p/Aw8SUvXcvJEDeV+SoV2+A/h558nwHmhiyAtp2sIEdzzYQ4u6Yrg==', N'300e09e8-58de-4ffc-9954-60373ffa4404', NULL, 0, 0, NULL, 1, 0, N'quest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'716a85d8-e0c4-4627-8bb2-542ab7e9a710', N'admin@vidly.com', 0, N'ANTHHQsEYzr0a4QTui3rp8nexZ1vuHS/p37a0nDeWWBpM076QoEhnwDeQnjBuERDKQ==', N'fbdf8dcd-509b-4afb-954f-09596e3eddcf', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9a7ff08f-8cb3-4920-849b-78c36d6fa4aa', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'716a85d8-e0c4-4627-8bb2-542ab7e9a710', N'9a7ff08f-8cb3-4920-849b-78c36d6fa4aa')


");
        }
        
        public override void Down()
        {
        }
    }
}
