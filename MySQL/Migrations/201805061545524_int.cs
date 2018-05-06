namespace MySQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _int : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Surname = c.String(unicode: false),
                        BornDateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(unicode: false),
                        Type = c.Int(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false, precision: 0),
                        Borrowed = c.Boolean(nullable: false, defaultValue: false),
                        AuthorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId);
            
            CreateTable(
                "dbo.BookHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BorrowedDate = c.DateTime(nullable: false, precision: 0),
                        ReturnDate = c.DateTime(nullable: false, precision: 0),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Readers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Surname = c.String(unicode: false),
                        BornDateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReaderBorrowBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        ReaderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Readers", t => t.ReaderId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.ReaderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReaderBorrowBooks", "ReaderId", "dbo.Readers");
            DropForeignKey("dbo.ReaderBorrowBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.BookHistories", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.ReaderBorrowBooks", new[] { "ReaderId" });
            DropIndex("dbo.ReaderBorrowBooks", new[] { "BookId" });
            DropIndex("dbo.BookHistories", new[] { "BookId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.ReaderBorrowBooks");
            DropTable("dbo.Readers");
            DropTable("dbo.BookHistories");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
