using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using MySQL;
using Repositories.Repositories;

namespace DiAutofac
{
    public class DiContainer
    {
        private static IContainer _container = null;

        public static IContainer Container
        {
            get
            {
                if (_container == null)
                    Build();

                return _container;
            }
        }

        public static void Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ConnectDb>().SingleInstance();

            builder.RegisterType<AuthorRepository>().SingleInstance();
            builder.RegisterType<BookHistoryRepository>().SingleInstance();
            builder.RegisterType<BookRepository>().SingleInstance();
            builder.RegisterType<ReaderBorrowBookRepository>().SingleInstance();
            builder.RegisterType<ReaderRepository>().SingleInstance();
            

            //Type repInterfaceType = typeof(IRepository<>);
            //Assembly assembly = repInterfaceType.Assembly;
            //IEnumerable<Type> repositoryTypes = from x in assembly.GetTypes()
            //                                    from z in x.GetInterfaces()
            //                                    let y = x.BaseType
            //                                    where
            //                                        (y != null && y.IsGenericType &&
            //                                         repInterfaceType.IsAssignableFrom(y.GetGenericTypeDefinition())) ||
            //                                        (z.IsGenericType &&
            //                                         repInterfaceType.IsAssignableFrom(z.GetGenericTypeDefinition()))
            //                                    select x;

            //foreach (var typeRepo in repositoryTypes)
            //    builder.Register(c => Activator.CreateInstance(typeRepo)).SingleInstance();

            _container = builder.Build();
        }
    }
}
