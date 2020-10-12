using System;

namespace ConsoleApp1
{
    class Product
    {
        public static int __id_gen = 0;

        protected int _id;
        protected int _price;
        protected int _quant;

        public Product()
        {
            this._price = 0;
            this._quant = 0;
            this._id = ++__id_gen;
        }
        public Product(int price, int quant)
        {
            this._price = price;
            this._quant = quant;
            this._id = ++__id_gen;
        }

        public int id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        //getter and setter for name
        public int price
        {
            get { return this._price; }
            set { this._price = value; }
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

        public void summary()
        {
            Console.WriteLine("This is a " + this.get_type());
            Console.WriteLine("Price: " + this._price + "\tQuantity: " + this._quant + "\n");
        }
    }

    class Book : Product
    {
        public Book() : base()
        {
            ;
        }
        
        public Book(int price, int quant)
            : base(price, quant)
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
            ;
        }
        public Computer(int price, int quant)
            : base(price,quant)
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
            ;
        }
        public Table(int price, int quant)
            :base(price,quant)
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

            Console.WriteLine(b1.get_type());
            Console.WriteLine(b1.quant);


            Product[] prod = new Product[100];
            int index_p = 0;
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("What product do you want? ");
                int choice = 0;

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 4)
                    break;

                int price = 0;
                int quant = 0;
                int index_item;
                int replenish_quant = 0;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Price?");
                        price = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Quantity?");
                        quant = Convert.ToInt32(Console.ReadLine());
                        
                        prod[index_p++] = new Book(price,quant);
                        break;

                    case 2:
                        Console.WriteLine("Price?");
                        price = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Quantity?");
                        quant = Convert.ToInt32(Console.ReadLine());
                        
                        prod[index_p++] = new Computer(price,quant);
                        break;

                    case 3:
                        Console.WriteLine("Price?");
                        price = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Quantity?");
                        quant = Convert.ToInt32(Console.ReadLine());
                        
                        prod[index_p++] = new Table(price,quant);
                        break;

                    case 5://replenish (add the quantity of product)
                        Console.WriteLine("Please Key in The Index of Item: ");
                        index_item = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please key in the replenish amount: ");
                        replenish_quant = Convert.ToInt32(Console.ReadLine());

                        prod[index_item].quant += replenish_quant;
                        break;

                    case 6: //sell (minus the quantity of product)
                        Console.WriteLine("Please Key in The Index of Item: ");
                        index_item = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please key in the sell amount: ");
                        replenish_quant = Convert.ToInt32(Console.ReadLine());

                        prod[index_item].quant -= replenish_quant;

                        if (prod[index_item].quant < 0)
                            throw new NullReferenceException();

                        break;
                }

                for(int i=0;i<index_p;i++)
                {
                    Console.Write(i + ". ");
                    prod[i].summary();
                }
            }



        }
    }
}
