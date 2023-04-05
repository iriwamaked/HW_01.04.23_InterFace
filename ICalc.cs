using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_01._04._23
{
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    public interface IOutput2
    {
        void ShowEven();
        void ShowOdd();
    }

    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}
