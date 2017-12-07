using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddPractice
{
    public class DataHelper
    {
        public List<int> GetEvenNumber(List<int> inputList)
        {
            var returnVal = inputList.Where(x => x % 2 == 0).ToList();
            return returnVal;
        }

        public string GetWord(List<string> inputList, string matchString)
        {
            var returnVal = inputList.Find(x => x == matchString);
            return returnVal;
        }

        public List<string> SortList(List<string> inputList)
        {
            inputList.Sort();
            return inputList;
        }
    }
}
