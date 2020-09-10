namespace MovieCustomerMVCwithAuthen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense]) VALUES (N'5700685e-d809-4471-9dd7-bd7cf6d15031', N'hemathumala@gmail.com', 0, N'AIrVHKnnPF3t1MsRmYZHWr9GrggKN7tCq7IuZun71z6nbOsvyz9Nd29yf7myF06BJw==', N'174b70fe-dba2-4e50-aee7-98de9c1a288b', NULL, 0, 0, NULL, 1, 0, N'hemathumala@gmail.com', N'1234abcd')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'be718e2a-66ea-42c4-be72-df14cf2a55a9', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2c6f32de-d913-4b2c-87b5-3c3270f96ac7', N'be718e2a-66ea-42c4-be72-df14cf2a55a9')");
        }
        
        public override void Down()
        {
        }
    }
}
