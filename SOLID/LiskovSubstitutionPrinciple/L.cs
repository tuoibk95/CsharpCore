using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple
{
    /// <summary>
    /// Subtypes must be substitutable for their base type.(the type can be interface, class, or abstract class in C#.)
    /// Nói cách đơn giản: A derived class must be correctly substitutable for its base class. 
    /// Khi 1 lớp kế thừa từ lớp base: nó phải implement tất cả methods trong lớp base , k nên loại bỏ 1 số methods bằng cách throw NotImplementedException
    /// </summary>
    public interface L
    {
        void Add(int item);
        void Remove(int item);
        int Get(int idex);
    }

    /// <summary>
    /// LSP suggests that the subtype must be substitutable for the base class or base interface
    /// we should create another interface for read-only collection without Add() and Remove() methods.
    /// 
    /// * A derived class should correctly implement methods of a base class
    /// </summary>
    public class MyReadOnlyCollection : L
    {
        private IList<int> _collection;

        public MyReadOnlyCollection(IList<int> col)
        {
            _collection = col;
        }
        public int Get(int index)
        {
            return _collection[index];
        }
		#region MyReadOnlyCollection class read only collection => không thể add or remove bất kì item nào
		public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public void Remove(int item)
        {
            throw new NotImplementedException();
        }
		#endregion
	}
}
