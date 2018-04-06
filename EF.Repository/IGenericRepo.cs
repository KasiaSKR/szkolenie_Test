using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Repository
{
    public interface IGenericRepo<T> //T-typ przez nas narzucony
    {
        List<T> GetAll();

        T GetById(int id);

        void Add(T t);
        void Delete(int id);
        void Update(int id, T t);

        //adv
        //T GetByCustom(Func<T, bool> predicate); 
    }
}
