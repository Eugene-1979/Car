using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Car
{

    internal class CarFactory
    {

        private Cabriolet _cabriolet;
        private Sedan _sedan;


        public Cabriolet CreateCabriolet(int x ,Engine? myPropertyEngine, Wheel? myPropertyWheel) {

            return _cabriolet.CreateCabriolet(x, myPropertyEngine, myPropertyWheel);
        }
        public Sedan CreateSedan(Engine? myPropertyEngine, Wheel? myPropertyWheel) {

            return _sedan.CreateSedan(myPropertyEngine,myPropertyWheel);
        }

        private ModelFactory _mf;
        public CarFactory(ModelFactory mf)
        {
            _sedan = mf.SedanFactory();
            _cabriolet = mf.CabrioletFactory();

        }
    }
    internal abstract class ModelFactory
    {
        public abstract Cabriolet CabrioletFactory();
        public abstract Sedan SedanFactory();

    }

    class ToyotaFactory : ModelFactory
    {
        public override Cabriolet CabrioletFactory()
        {
            return new CabrioletToyota();
        }

        public override Sedan SedanFactory()
        {
            return new SedanToyota();
        }
    }

    class BmwFactory : ModelFactory
    {
        public override Cabriolet CabrioletFactory()
        {
            return new CabrioletBMW();
        }

        public override Sedan SedanFactory()
        {
            return new SedanBMW();
        }
    }


    abstract class Cabriolet
    {
        public Cabriolet() { }
       protected int x; 
       protected Engine? myPropertyEngine;
       protected Wheel? myPropertyWheel;

        protected Cabriolet(int x, Engine? myPropertyEngine, Wheel? myPropertyWheel)
        {
            this.x = x;
            this.myPropertyEngine = myPropertyEngine;
            this.myPropertyWheel = myPropertyWheel;
        }

        public abstract Cabriolet CreateCabriolet(int x,Engine? myPropertyEngine, Wheel? myPropertyWheel);
    }

    abstract class Sedan
    {
        public Sedan() { }
       protected Engine? myPropertyEngine;
       protected Wheel? myPropertyWheel;

        protected Sedan(Engine? myPropertyEngine, Wheel? myPropertyWheel)
        {
            this.myPropertyEngine = myPropertyEngine;
            this.myPropertyWheel = myPropertyWheel;
        }

        public abstract Sedan CreateSedan(Engine? myPropertyEngine, Wheel? myPropertyWheel);
    }

    class CabrioletBMW : Cabriolet
    {
        public CabrioletBMW() { }
        public CabrioletBMW(int x, Engine? myPropertyEngine, Wheel? myPropertyWheel) : base(x, myPropertyEngine, myPropertyWheel)
        {
        }

        public override Cabriolet CreateCabriolet(int x, Engine? myPropertyEngine, Wheel? myPropertyWheel)
        {
            return new CabrioletBMW(x, myPropertyEngine, myPropertyWheel);
        }
        public override string ToString()
        {
            return $"CabrioletBMW {x} {myPropertyEngine} {myPropertyWheel}";
        }
    }
    class CabrioletToyota : Cabriolet
    {
        public CabrioletToyota() { }
        public CabrioletToyota(int x, Engine? myPropertyEngine, Wheel? myPropertyWheel) : base(x, myPropertyEngine, myPropertyWheel)
        {
        }

        public override Cabriolet CreateCabriolet(int x, Engine? myPropertyEngine, Wheel? myPropertyWheel)
        {
            return new CabrioletToyota(x, myPropertyEngine, myPropertyWheel);
        }
        public override string ToString()
        {
            return $"CabrioletToyota {x} {myPropertyEngine} {myPropertyWheel}";
        }
    }
    class SedanBMW : Sedan
    {
        public SedanBMW() { }
        public SedanBMW(Engine? myPropertyEngine, Wheel? myPropertyWheel) : base(myPropertyEngine, myPropertyWheel)
        {
        }

        public override Sedan CreateSedan(Engine? myPropertyEngine, Wheel? myPropertyWheel)
        {
            return new SedanBMW(myPropertyEngine, myPropertyWheel);
        }
        public override string ToString()
        {
            return $"SedanBMW {myPropertyEngine} {myPropertyWheel}";
        }
    }
    class SedanToyota : Sedan
    {
        public SedanToyota() { }
        public SedanToyota(Engine? myPropertyEngine, Wheel? myPropertyWheel) : base(myPropertyEngine, myPropertyWheel)
        {
        }
        public SedanToyota(int g) { }
        public override Sedan CreateSedan(Engine? myPropertyEngine, Wheel? myPropertyWheel)
        {
            return new SedanToyota(myPropertyEngine, myPropertyWheel);
        }
        public override string ToString()
        {
            return $"SedanToyota {myPropertyEngine} {myPropertyWheel}";
        }
    }
}
