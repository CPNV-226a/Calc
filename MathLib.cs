﻿using Calculator;
using System.Diagnostics;

namespace CalculatorB2B
{
    public static class MathLib
    {
        public static float Add(MathRequest mathRequest)
        {
            return mathRequest.Op1() + mathRequest.Op2();
        }

        public static float Sub(MathRequest mathRequest)
        {
            return mathRequest.Op1() - mathRequest.Op2();
        }

        public static float Mul(MathRequest mathRequest)
        {
            return mathRequest.Op1() * mathRequest.Op2();
        }

        public static float Div(MathRequest mathRequest)
        {
            return mathRequest.Op1() / mathRequest.Op2();
        }

        public class CalcException : Exception { };
        public class BadOperatorException : Exception { };
    }
}
