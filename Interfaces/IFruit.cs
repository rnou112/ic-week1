using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDev_Week1.Interfaces
{
    interface ILaundry
    {
        void WashClothes();
        void DryClothes();
    }


    internal interface IFruit
    {
        string GetColor();
    }

    /*
    public abstract class IFruit
    {
        public abstract string GetColor();
    }*/
}
