using System.Data.Entity.ModelConfiguration.Conventions;

namespace Demo.Domain
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BlogModel : DbContext
    {
        // 您的內容已設定為使用應用程式組態檔 (App.config 或 Web.config)
        // 中的 'BlogModel' 連接字串。根據預設，這個連接字串的目標是
        // 您的 LocalDb 執行個體上的 'Demo.Domain.BlogModel' 資料庫。
        // 
        // 如果您的目標是其他資料庫和 (或) 提供者，請修改
        // 應用程式組態檔中的 'BlogDb' 連接字串。
        public BlogModel()
            : base("name=iNetDb")
        {
        }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<Colume> Columes { get; set; }


        // 針對您要包含在模型中的每種實體類型新增 DbSet。如需有關設定和使用
        // Code First 模型的詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=390109。

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        //public virtual DbSet<Blog> Blogs { get; set; }
        //public virtual DbSet<BlogInfo> BlogInfo { get; set; }
        //public virtual DbSet<BlogArticle> BlogArticles { get; set; }
        //public virtual DbSet<BlogFile> BlogFiles { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    var blogTable = modelBuilder.Entity<Blog>().ToTable("Blogs");
        //    var blogArticleTable = modelBuilder.Entity<BlogArticle>().ToTable("BlogArticles");
        //    var blogInfo = modelBuilder.Entity<BlogInfo>().ToTable("BlogInfo");
        //    var blogFile = modelBuilder.Entity<BlogFile>().ToTable("BlogFiles");

        //    // 移除表格複數化規則
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    blogTable
        //        .Property(c => c.Id)
        //        .IsRequired()
        //        .HasColumnType("bigint");

        //    blogArticleTable
        //        .Property(c => c.BlogId)
        //        .IsRequired()
        //        .HasColumnType("bigint");
        //    blogArticleTable
        //        .Property(c => c.Subject)
        //        .HasMaxLength(250)
        //        .IsRequired();
        //    blogArticleTable
        //        .Property(c => c.Body)
        //        .HasMaxLength(4000)
        //        .IsRequired();

        //    // relationship configuration.
        //    // define primary key.
        //    blogTable.HasKey(c => c.Id);

        //    // 1-to-0 relationship
        //    blogTable
        //        .HasRequired(c => c.Info)
        //        .WithRequiredPrincipal(c => c.Blog)
        //        .Map(m =>
        //        {
        //            m.MapKey("BlogId");
        //        });

        //    // 1-to-1 relationship
        //    //blogInfo
        //    //    .HasKey(c => c.Id)
        //    //    .HasRequired(c => c.Blog)
        //    //    .WithRequiredPrincipal(c => c.Info);

        //    // 1-to-n relationship.

        //    blogTable.HasMany(c => c.Articles).WithRequired(c => c.Blog);

        //    // m-to-n relationship.
        //    blogArticleTable
        //        .HasKey(c => c.Id)
        //        .HasMany(c => c.Files)
        //        .WithMany(c => c.Articles)
        //        .Map(m =>
        //        {
        //            m.ToTable("BlogArticleFiles");
        //            m.MapLeftKey("BlogArticleId");
        //            m.MapRightKey("BlogFileId");
        //        });

        //    // stored procedure mapping discussed at 4.6.6 section.
        //    // blogTable.MapToStoredProcedures();
        //    /*
        //    blogTable.MapToStoredProcedures(
        //        m =>
        //        {
        //            m.Insert(i =>
        //                {                            
        //                    i.HasName("blog_add")
        //                        .Parameter(c => c.OwnerId, "ownerId")
        //                        .Parameter(c => c.Caption, "caption")
        //                        .Result(c => c.Id, "blogId");
        //                });
        //            m.Update(u =>
        //                {
        //                    u.HasName("blog_update")
        //                        .Parameter(c => c.Id, "id")
        //                        .Parameter(c => c.OwnerId, "ownerId")
        //                        .Parameter(c => c.Caption, "caption");
        //                });
        //            m.Delete(d =>
        //                {
        //                    d.HasName("blog_delete")
        //                        .Parameter(c => c.Id, "id");
        //                });
        //        });
        //    */
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}