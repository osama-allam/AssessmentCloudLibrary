using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using CloudLibrary.Data.Common.Contracts.Entities;
using CloudLibrary.Data.Common.Contracts.Repositories;
using CloudLibrary.Data.Common.Persistence.Entities;

namespace CloudLibrary.Data.Common.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : IDirectoryEntity<string>
    {
        protected readonly string _root;
        public Repository(string root)
        {
            _root = root;
        }

        public TEntity Get(object id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        public TEntity Add(TEntity entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            var directoryPath = Path.Combine(_root, entity.Name);
            if (!Directory.Exists(directoryPath)) 
            {  
                Directory.CreateDirectory(directoryPath);
                var configurationFilePath = Path.Combine(directoryPath, $"{entity.Name}_configuration.json");
                File.WriteAllText(configurationFilePath, entity.ToJson());
            }
            return entity;
        }

        public void Remove(TEntity entity)
        {
            var path = Path.Combine(_root, entity.Name);
            if (Directory.Exists(path))  
            {  
                Directory.Delete(path); 
            }  
        }
    }
}