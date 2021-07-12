using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioseca.Model;
using NHibernate;
using NHibernate.Cfg;

namespace Biblioseca.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ISessionFactory sessionFactory = new Configuration()
                .Configure()
                .BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();

            Book book = new Book();
            /* author.FirstName = "Steve";
             author.LastName = "Rogers"; */
            book.Title = "Operación Masacre";
            book.AuthorId = 1;
            book.Description = "Operacion Masacre";
            book.Category = "Policial";
            book.ISBN = "123456";
            session.Save(book);

            Console.WriteLine(book.Id);
            Console.ReadKey();
        }
    }
}
 