using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public sealed class OperatorOverloadWithReflection
    {
        private readonly IOperatorOverloadWithReflection operatorOverload;

        public OperatorOverloadWithReflection(IOperatorOverloadWithReflection operatorOverload)
        {
            this.operatorOverload = operatorOverload;
        }

        public OperatorDeclarationSyntax Declaration
        {
            get { return operatorOverload.Declaration; }
        }

        public TypeWithReflection DeclaringType
        {
            get { return TypeWithReflection.GetType(operatorOverload.DeclaringType); }
        }

        public int EndLine
        {
            get { return operatorOverload.EndLine; }
        }

        public int StartLine
        {
            get { return operatorOverload.StartLine; }
        }

        public IMethodSymbol Symbol
        {
            get { return operatorOverload.Symbol; }
        }

        public void Accept(ReflectionVisitor visitor)
        {
            operatorOverload.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return operatorOverload.ToString();
        }
    }
}
