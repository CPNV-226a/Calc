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
        private float op1;
        private float op2;
        private char ope;
        private float result;
        #endregion private attributs

        #region public methodes
        public MathRequest(float op1, char ope, float op2)
        {
            this.op1 = op1;
            this.ope = ope;
            this.op2 = op2;
        }

        public float Op1()
        {
            return this.op1;
        }

        public char Ope()
        {
            return this.ope;
        }

        public float Op2()
        {
            return this.op2;
        }

        public float Result
        {
            get
            {
                return this.result;
            }
            set
            {
                this.result = value;
            }
        }

        public override String ToString()
        {
            return "Calculation is " + this.op1 + " " + this.ope + " " + this.op2 + " = " + this.result;
        }
        #endregion public methodes

    }
}
