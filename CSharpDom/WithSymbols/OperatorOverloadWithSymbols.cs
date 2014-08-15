using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class OperatorOverloadWithSymbols : AbstractSymbolNode<IOperatorOverloadWithSymbols>
    {
        private readonly IOperatorOverloadWithSymbols operatorOverload;

        public OperatorOverloadWithSymbols(IOperatorOverloadWithSymbols operatorOverload)
            : base(operatorOverload)
        {
            this.operatorOverload = operatorOverload;
        }

        public OperatorDeclarationSyntax Declaration
        {
            get { return operatorOverload.Declaration; }
        }

        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(operatorOverload.DeclaringType); }
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

        public override void Accept(SymbolsVisitor visitor)
        {
            operatorOverload.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
