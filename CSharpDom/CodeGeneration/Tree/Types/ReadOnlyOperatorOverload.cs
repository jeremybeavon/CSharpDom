using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyOperatorOverload : IOperatorOverload
    {
        private readonly IOperatorOverload operatorOverload;

        public ReadOnlyOperatorOverload(ReadOnlyBinaryOperator operatorOverload)
        {
            this.operatorOverload = operatorOverload;
        }

        public void Accept(IGenericVisitor visitor)
        {
            operatorOverload.Accept(visitor);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            operatorOverload.AcceptChildren(visitor);
        }
    }
}
