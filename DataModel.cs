﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddPractice
{
    public class DataModel
    {
        public List<int> listOfInt = Enumerable.Range(1, 20).ToList();
        public List<string> listOfString = new List<string>() { "word", "word1", "word2" };
    }
}
