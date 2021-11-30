
namespace Listy.Models
{
    class SLList<T>
    {
        private Node<T> head;
        public void Add(T value) {
            if(head == null) {
                head = new Node<T>(value);
            }
            else
            {
                Node<T> temp = new Node<T>(value);
                temp.next = head;
                head = temp; 
            }
        }
        public override string ToString()
        {
            string res = "[";
            Node<T> runner = head;
            while(runner != null) {
                res += $"{runner.value}, ";
                runner = runner.next; 
            }
            return res + "]";
        }
    }
}