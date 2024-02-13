using System;

namespace appConsDemo
{
    internal class Program
    {
        static void Main()
        {
            double varLeftOp = clsUtilities.opReadNumberWith<int>("Left operand");
            double varRightOp = clsUtilities.opReadNumberWith<int>("Right operand");
            Console.Write(clsUtilities.opAdd(varLeftOp, varRightOp));
            Console.ReadKey();
        }
    }
}