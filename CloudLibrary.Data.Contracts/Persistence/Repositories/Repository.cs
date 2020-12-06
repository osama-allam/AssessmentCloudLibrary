using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using CloudLibrary.Data.Common.Contracts.Entities;
using CloudLibrary.Data.Common.Contracts.Repositories;
using CloudLibrary.Data.Common.Persistence.Entities;
using Newtonsoft.Json;

namespace CloudLibrary.Data.Common.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : IDirectoryEntity<string>
    {
        protected readonly string _root;
        public Repository(string root)
        {
            _root = root;
        }

        public TEntity Get(object name)
        {
            return Find(name.ToString()).FirstOrDefault();
        }

        public IEnumerable<TEntity> Find(string address)
        {
            var result = new List<TEntity>();
            var directoryPath = Path.Combine(_root, address);
            var dirInfo = new DirectoryInfo(directoryPath);
            if (Directory.Exists(directoryPath))
            {
                var directoryEntityFiles = dirInfo.GetFiles("*.json");
                foreach (var file in directoryEntityFiles)
                {
                    var directoryEntity = JsonConvert.DeserializeObject<TEntity>(File.ReadAllText(file.FullName));
                    result.Add(directoryEntity);
                }
            }
            return result;
        }
        public TEntity Add(TEntity entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            var directoryPath = Path.Combine(_root, entity.Address);
            if (!Directory.Exists(directoryPath))
            {  
                Directory.CreateDirectory(directoryPath);
            }
            var configurationFilePath = Path.Combine(directoryPath, $"{entity.Name}_configuration.json");
            File.WriteAllText(configurationFilePath, entity.ToJson());
            return entity;
        }

        public void Remove(TEntity entity)
        {
            var directoryPath = Path.Combine(_root, entity.Address);
            if (Directory.Exists(directoryPath))
            {
                // the true parameter here is to make recursive delete for that directory as requested in requirements
                Directory.Delete(directoryPath, true);
            }  
        }
    }
}