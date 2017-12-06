using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddPractice
{
    public class DataHelper
    {
        DataModel DM = new DataModel();
        public bool ValidateIsEven(int n)
        {

            return (n % 2 == 0);
        }

        public bool ValidateIsPopulated(List<int> n)
        {
            return (n.Count > 0);
        }


    }
}
