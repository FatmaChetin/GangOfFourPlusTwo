using Project.BLL.DesignPattern.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.GenericRepository.BaseRep
{
    public abstract class BaseRepository<T>
    {
        MyContext _db;

        public BaseRepository()
        {
            _db = DBTool.DbInstance;
        }
    }
}
