using Node;

namespace LinkedList
{
    public class LinkedList<T>
    {
        public Node<T>? Head { get; set; }
        public Node<T>? Tail { get; set; }
        public int Counter { get; set; }

        public void AddHead(T value)
        {
            if (Counter == 0)
            {
                Head = Tail = new Node<T>(value);
                Head.Next = Tail.Next = null;
                Counter++;
                return;
            }

            Node<T> temp = Head;
            Head = new Node<T>(value);
            Head.Next = temp;
            Counter++;
        }
        public void AddTail(T value)
        {
            if (Counter == 0)
            {
                Head = Tail = new Node<T>(value);
                Head.Next = Tail.Next = null;
                Counter++;
                return;
            }
            Node<T> temp = Head;
            while (temp != null)
            {
                Node<T> node = temp;
                if (node.Next == null)
                {
                    var newTemp = Tail;
                    Tail = new Node<T>(value);
                    newTemp.Next = Tail;
                    Counter++;
                    break;
                }
                temp = temp.Next;
            }
        }
        public void RemoveHead()
        {
            if (Counter == 0)
            {
                throw new Exception("List is empty");
            }

            if (Counter == 1)
            {
                Head = Tail = null;
                Counter--;
                return;
            }
            Head = Head.Next;
            Counter--;
        }

        public void RemoveTail()
        {
            if (Counter == 0)
            {
                throw new Exception("List is empty");
            }
            if (Counter == 1)
            {
                Head = Tail = null;
                Counter--;
                return;
            }
            var temp = Head;
            while (temp != null)
            {
                var t1 = temp.Next;

                if (t1.Next == null)
                {
                    Tail = temp;
                    Tail.Next = null;
                    Counter--;
                    break;
                }
                temp = t1;
            }
        }
        public void List()
        {
            if (Counter == 0)
            {
                throw new Exception("List is empty");
            }
            var temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
        public int Count()
        {
            return Counter;
        }

        public T GetHead()
        {
            if (Counter == 0)
            {
                throw new Exception("LinkedList is Empty");
            }
            return Head.Value;
        }
        public T GetTail()
        {
            if (Counter == 0)
            {
                throw new Exception("LinkedList is empty");
            }
            return Tail.Value;
        }

        public bool Contains(T value)
        {
            if (Counter == 0)
            {
                return false;
            }

            var temp = Head;
            while (temp != null)
            {
                if (temp.Value.Equals(value))
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }
    }
}
