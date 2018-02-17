using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertitance
{
    abstract class NPC
    {
        #region Fields

        private int _id;
        private string _name;
        private int _location;

        #endregion

        #region Properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Location
        {
            get { return _location; }
            set { _location = value; }
        }

        #endregion

        #region Constructors

        #endregion

        #region Methods

        public virtual string Greeting() // virtual means that overriding is optional
        {
            return $"Hello, my name is {_name}";
        }

        public abstract string DefendResponse();

        #endregion

    }

    class Merchant : NPC // Dependent upon the NPC class
    {
        #region Fields

        private string _shopName;

        #endregion

        #region Properties

        public string ShopName
        {
            get { return _shopName; }
            set { _shopName = value; }
        }

        #endregion

        #region Constructors

        #endregion

        #region Methods

        public override string DefendResponse()
        {
            return "Run away!!!";
        }

        #endregion

    }

    class Warrior : NPC // Dependent upon the NPC class
    {
        #region Fields

        private string _weapon;

        #endregion

        #region Properties

        public string Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        #endregion

        #region Constructors

        #endregion

        #region Methods

        public override string Greeting() // overrides the virtual Greeting method from the NPC class
        {
            return $"Ahhhhhhhh, my name is {base.Name}."; // NPC is the base class, so we are calling the base
        }

        public override string DefendResponse()
        {
            return "Kill, kill, kill!";
        }

        #endregion

    }

    class Program
    {
        static void Main(string[] args)
        {
            Merchant marvin = new Merchant();
            marvin.ShopName = "The Wounded Skeever";
            marvin.Name = "Marvin";
            marvin.Id = 33;
            marvin.Location = 5;

            Warrior thor = new Warrior() // object initializer
            {
                Id = 12,
                Name = "Thor",
                Location = 67,
                Weapon = "Sword",
            };

            Console.WriteLine(marvin.Greeting());

            Console.ReadKey();
        }
    }
}
