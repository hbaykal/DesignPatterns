using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.Decorator
{
    public abstract class CarBase
    {
        public abstract string Mark { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal HirePrice { get; set; }
    }

    public class PersonalCar : CarBase
    {
        public override decimal HirePrice { get; set; }
        public override string Mark { get; set; }
        public override string Model { get; set; }
    }

    public class CorporateCar : CarBase
    {
        public override decimal HirePrice { get; set; }
        public override string Mark { get; set; }
        public override string Model { get; set; }
    }

    public abstract class CarDecoratorBase: CarBase
    {
        private CarBase _carBase;
        public CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }         
    }

    public class SpecialOffer : CarDecoratorBase
    {
        public decimal DiscountPercentage { get; set; }
        private readonly CarBase _carBase;
        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }

        public override decimal HirePrice
        {
            get { return _carBase.HirePrice * ((100-DiscountPercentage)/100); }
            set { }
        }

        public override string Mark { get; set; }

        public override string Model { get; set; }
    }
}
