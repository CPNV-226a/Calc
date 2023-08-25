using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MathRequest
    {
        #region private attributs
        private float _op1;
        private float _op2;
        private char _ope;
        private float _result;
        #endregion private attributs

        #region public methodes
        public MathRequest(float op1, char ope, float op2)
        {
            _op1 = op1;
            _ope = ope;
            _op2 = op2;
        }

        public float Op1()
        {
            return _op1;
        }

        public char Ope()
        {
            return _ope;
        }

        public float Op2()
        {
            return _op2;
        }

        public float GetResult()
        {
            return _result;
        }

        public void SetResult(float result)
        {
            _result = result;
        }
        #endregion public methodes


    }
}
