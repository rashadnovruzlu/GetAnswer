using GetAnswer.Repository;
using GetAnswer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;

namespace GetAnswer.Helpers
{
    public sealed class GetAnswerContainer
    {
        public Type Type { get; set; }
        public object Repository { get; set; }
        public Type Service { get; set; }
    }

    public interface IGetAnswerResolver
    {
        T Create<T>();
        int Commit();
    }

    public sealed class GetAnswerResolver : IGetAnswerResolver
    {
        private DbContext _context;
        private IUnitOfWork _unitOfWork;

        //Services keep in container 
        private readonly List<GetAnswerContainer> _container = new List<GetAnswerContainer>();

        /// <summary>
        /// If you want would be change default context
        /// </summary>
        /// <param name="context"></param>
        public GetAnswerResolver(DbContext context)
        {
            _context = context;
            _unitOfWork = new UnitOfWork(_context);
        }

        //Default constructor
        public GetAnswerResolver()
        {
            _context = new GetAnswerContext();
            _unitOfWork = new UnitOfWork(_context);
        }

        /// <summary>
        /// Generate appropriate class
        /// </summary>
        /// <typeparam name="T">Interface</typeparam>
        /// <returns></returns>
        public T Create<T>()
        {
            //Find type
            var iService = typeof(T);

            //Check before create
            var row = _container.FirstOrDefault(x => x.Type == iService);

            //If exists in the container read from container
            if (row != null)
            {
                object[] args = new object[] { _unitOfWork, row.Repository };

                return (T)Convert.ChangeType(Activator.CreateInstance(row.Service, args), row.Service);
            }
            else
            {
                //Then use for is added in container
                GetAnswerContainer container = new GetAnswerContainer();

                container.Type = iService;

                var service = FindClass(iService);

                container.Service = service;

                //Find repository
                var iRepo = FindProperty(service);

                //Create instance from appropriate repository
                var repoInstance = (Activator.CreateInstance(FindClass(iRepo), _context));

                container.Repository = repoInstance;

                object[] args = new object[] { _unitOfWork, repoInstance };

                //Sought service is creating
                var serviceInstance = Activator.CreateInstance(service, args);

                //Add to countainer
                _container.Add(container);

                return (T)Convert.ChangeType(serviceInstance, service);
            }
        }

        /// <summary>
        /// Save all changes
        /// </summary>
        public int Commit()
        {
            return _unitOfWork.Commit();
        }

        /// <summary>
        /// Find class which it implement "type" interface
        /// </summary>
        /// <param name="type">Interface</param>
        /// <returns></returns>
        private static Type FindClass(Type type)
        {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes())
                   .Where(p => type.IsAssignableFrom(p) && !p.IsInterface).FirstOrDefault();
        }

        /// <summary>
        /// Find property type
        /// </summary>
        /// <param name="type">any class</param>
        /// <returns></returns>
        private static Type FindProperty(Type type)
        {
            foreach (var item in type.GetRuntimeFields())
            {
                if (item.Name.IndexOf("Repos") > -1) return item.FieldType;
            }

            return null;
        }

    }
}