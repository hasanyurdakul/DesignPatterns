using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class OfferDiscountPrice : CarBaseDecorator
    {
        private CarBase _carBase;
        public int DiscountRate { get; set; }

        public OfferDiscountPrice(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }

        public override decimal ListPrice
        {
            get => _carBase.ListPrice * DiscountRate / 100;
            set { }
        }
    }
}
