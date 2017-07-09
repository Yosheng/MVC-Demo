using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Domain;
using Demo.Repository.Impl;

namespace Demo.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<BlogModel>(new DropCreateDatabaseAlways<BlogModel>());

            using (var blogModel = new BlogModel())
            {
                blogModel.Database.Initialize(true);
            }

            using (var uow = new UnitOfWork(new BlogModel()))
            {
                foreach (var item in uow.GetRepository<Template>().All())
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
