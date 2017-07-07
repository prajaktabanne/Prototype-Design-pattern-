using System;

namespace DoFactory.GangOfFour.Prototype.Structural
{

    class MainApp
    {

        static void Main()
        {
            // Create two instances and clone each

            YouTube p1 = new YouTube("YouTube");
            YouTube c1 = (YouTube)p1.Clone();
            Console.WriteLine("Name: {0}", p1.Id);

            Blog p2 = new Blog("Blog");
            Blog c2 = (Blog)p2.Clone();
            Console.WriteLine("Name: {0}", c2.Id);

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    abstract class Prototype
    {
        private string _id;

        // Constructor
        public Prototype(string id)
        {
            this._id = id;
        }

        // Gets id
        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }

    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    class YouTube : Prototype
    {
        // Constructor
        public YouTube(string id)
          : base(id)
        {
        }

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    class Blog : Prototype
    {
        // Constructor
        public Blog(string id)
          : base(id)
        {
        }

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}

