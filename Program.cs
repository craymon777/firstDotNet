using System;

namespace ConsoleApp1
{
    class Product
    {
        public static int __id_gen = 0;

        protected int _id;
        protected string _name;
        protected int _quant;

        public Product()
        {
            this._name = "product";
            this._quant = 0;
            this._id = ++__id_gen;
        }
        public Product(string name, int quant)
        {
            this._name = name;
            this._quant = quant;
            this._id = ++__id_gen;
        }

        public int id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        //getter and setter for name
        public string name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public int quant
        {
            get { return this._quant; }
            set { this._quant = value; }
        }

        public virtual string get_type()
        {
            return "product";
        }
    }

    class Book : Product
    {
        public int price = 0;

        public Book() : base()
        {
            this._name = this.get_type();
        }
        
        public Book(string name, int quant)
            : base(name, quant)
        {
            ;
        }

        public override string get_type()
        {
            return "Book";
        }

        //normal void function or method
        public void outputHello()
        {
            Console.WriteLine("hello test");
        }
    }

    class Computer : Product
    {
        public Computer() : base()
        {
            this._name = this.get_type();
        }
        public Computer(string name, int quant)
            : base(name,quant)
        {
            ;
        }

        public override string get_type()
        {
            return "Computer";
        }
    }

    class Table : Product
    {
        public Table() : base()
        {
            this._name = this.get_type();
        }
        public Table(string name, int quant)
            :base(name,quant)
        {
            ;
        }
        public override string get_type()
        {
            return "Table";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow .Net");

            Book b1 = new Book();

            Console.WriteLine(b1.name);
            Console.WriteLine(b1.quant);


            Product[] prod = new Product[100];
            int index_p = 0;


            while (true)
            {
                Console.WriteLine("What product do you want? ");
                int choice = 0;

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        prod[index_p++] = new Book();
                        break;

                    case 2:
                        prod[index_p++] = new Computer();
                        break;

                    case 3:
                        prod[index_p++] = new Table();
                        break;
                }
            }



        }
    }
}
