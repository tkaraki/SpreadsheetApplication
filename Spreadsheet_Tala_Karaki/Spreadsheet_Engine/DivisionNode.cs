﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadsheet_Engine
{
    internal class DivisionNode : OperatorNode
    {
        public DivisionNode() : base('/') { }

        public override double Evaluate()
        {
            try
            {
                return this.Left.Evaluate() / this.Right.Evaluate();
            }
            catch (Exception e)
            {
                throw new Exception("Error with Operator Children.");
            }
        }
    }

}
