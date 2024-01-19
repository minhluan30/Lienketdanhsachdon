using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lienketdanhsachdon
{
    class Node
    {
        private int info;
        private Node next;
        public Node(int x)
        {
            info = x;
            next = null;
        }
        public int Info
        {
            set { this.info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { this.next = value; }
            get { return next; }
        }
    }
    class Singlelinklist
    {
        private Node Head;
        public Singlelinklist()
        {
            Head = null;
        }
        public void Adhead(int x)
        {
            Node p = new Node(x);
            p.Next = Head;
            Head = p;
        }
        public void Addlast(int x)
        {
            Node p = new Node(x);
            if (Head == null)
            {
                Head = p;
            }
            else
            {
                Node q = Head;
                while(p.Next != null)
                {
                    q = q.Next;
                }
                p.Next = q;
            }
        }
        public void Processlist()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write($"{p.Info} ");
                p = p.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Singlelinklist ds = new Singlelinklist();
            ds.Adhead(9);
            ds.Adhead(5);
            ds.Adhead(6); 
            ds.Adhead(7);
            Console.WriteLine("Danh sach lien ket: ");
            ds.Processlist();
            Console.ReadLine();
        }
    }
}
