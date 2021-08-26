using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKata.Queue
{
    public class Queue
    {
        private readonly List<int> _list;
        public int Count => _list.Count;

        public Queue(int initialValue)
        {
            _list = new List<int>{initialValue};
        }

        public void Enqueue(int objToAdd)
        {
            _list.Add(objToAdd);
        }

        public int Dequeue()
        {
            CheckIfListIsEmpty();
            var itemToRemove = _list[0];
            _list.Remove(itemToRemove);
            return itemToRemove;

        }

        public int Peek()
        {
            CheckIfListIsEmpty();
            return _list[0];
        }

        private void CheckIfListIsEmpty()
        {
            if (!_list.Any())
                throw new Exception("Empty List");
        }


    }
}
