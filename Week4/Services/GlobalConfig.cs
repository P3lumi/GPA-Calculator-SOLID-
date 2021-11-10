using System;
using System.Collections.Generic;
using System.Text;
using Week4.Data_Access.File_Repository.implementation;
using Week4.Data_Access.File_Repository.interfaces;

namespace Week4.Services
{
    public static class GlobalConfig
    {
        public static ICalculator Calculator;
        public static ICollect collect;
        public static IDesign design;
        public static IFormula formula;
        public static IFileRepo filedb;
        public static void Instantiate()
        {
            filedb = new FileRepoService();
            formula = new Formula();
            Calculator = new Calculator();
            collect = new Collect(formula, filedb);
            design = new Design(Calculator);
            
            
        }
    }
}
