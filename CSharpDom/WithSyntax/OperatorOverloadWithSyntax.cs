using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class OperatorOverloadWithSyntax : AbstractSyntaxNode<IOperatorOverloadSyntax>
    {
        private readonly IOperatorOverloadSyntax operatorOverload;

        public OperatorOverloadWithSyntax(IOperatorOverloadSyntax operatorOverload)
            : base(operatorOverload)
        {
            this.operatorOverload = operatorOverload;
        }

        public OperatorDeclarationSyntax Declaration
        {
            get { return operatorOverload.Declaration; }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return TypeWithSyntax.GetType(operatorOverload.DeclaringType); }
        }

        public int EndLine
        {
            get { return operatorOverload.EndLine; }
        }

        public int StartLine
        {
            get { return operatorOverload.StartLine; }
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            operatorOverload.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitOperatorOverload(this);
        }
    }
}
