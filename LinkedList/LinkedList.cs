
namespace LinkedList.LinkedList
{
    public class MyLinkedList<T>
    {
        private Node<T> _first;
        private Node<T> _last;
        private int _count;
        
        public int Count => _count;
        public Node<T> First => _first;
        public Node<T> Last => _last;
        
        public void AddFirst(T item)
        {
            Node<T> node = new(item);
            if (IsHeadNull())
                _first = _last = node;
            else
            {
                _first.Previous = node;
                node.Next = _first;
                _first = node;
            }
            _count++;
        }
        
        public void AddLast(T item)
        {
            Node<T> node = new(item);

            if (IsHeadNull())
                _first = _last = node;
            else
            {
                _last.Next = node;
                node.Previous = _last;
                _last = node;
            }
            _count++;
        }

        public int IndexOf(T item)
        {
            int index = 0;
            var current = _first;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, item))
                    return index;
                current = current.Next;
                index++;
            }
            return -1;
        }

        public void RemoveFirst()
        {
            if (IsHeadNull())
                throw new InvalidOperationException();

            if (_first == _last)
                _first = _last = null;
            else
            {
                var secondNode = _first.Next;
                secondNode.Previous = null;
                _first.Next = null;
                _first = secondNode;
            }
            _count--;
        }

        public void RemoveLast()
        {
            if (IsHeadNull())
                throw new InvalidOperationException();

            if (_first == _last)
                _first = _last = null;
            else
            {
                var previousNode = GetPrevious(_last);
                previousNode.Next = null;
                _last = previousNode;
            }
            _count--;
        }
        
        public bool Contains(T item) => IndexOf(item) != -1;
        
        public T[] ToArray()
        {
            T[] array = new T[_count];
            var current = _first;
            var index = 0;
            while (current != null)
            {
                array[index++] = current.Value;
                current = current.Next;
            }
            return array;
        }

        #region Private
        private bool IsHeadNull() => _first == null;
        private Node<T> GetPrevious(Node<T> node)
        {
            var current = _first;
            while (current != null)
            {
                if (current.Next == node)
                    return current;

                current = current.Next;
            }
            return null;
        }
        #endregion
    }
}



