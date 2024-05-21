using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Node n1 = new Node(5);  //düğüm oluşturuldu.
            Node n2 = new Node(6);
            Node n3 = new Node(7);
            n1.next = n2;
            n2.next = n3;   
            n3.next = n1;
            Console.WriteLine("n1. düğümün değeri:"+n1.data);
            Console.WriteLine("n2. düğümün değeri:"+n2.data);
            Console.WriteLine("n3. düğümün değeri:"+n3.data);
            Console.WriteLine(n1.next.next.next.data);
            Console.WriteLine("************************");

            İsim a1 = new İsim("esma");
            İsim a2 = new İsim("aygül");
            İsim a3 = new İsim("makbule");
            a1.next = a2;
            a2.next = a3;
            a3.next = null;
            Console.WriteLine("a1. düğümün annesinin annesi:"+a1.next.next.ad);
            

        }
    }



    public  class Node
    {
        public int data;  //özellik
        public Node next;  //işaretçi

        public Node(int data)  //Yapıcı metod kullanıyoruz.
        {
            this.data = data;
            next = null;
        }
    }

    public class İsim
    {
        public string ad;
        public İsim next;
        public İsim(string ad)
        {
            this.ad = ad;   
            next=null;
        }
    }
}
