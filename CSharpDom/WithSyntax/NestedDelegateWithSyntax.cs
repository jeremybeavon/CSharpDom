using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class NestedDelegateWithSyntax : AbstractSyntaxNode<INestedDelegateSyntax>
    {
        private readonly INestedDelegateSyntax @delegate;

        public NestedDelegateWithSyntax(INestedDelegateSyntax @delegate)
            : base(@delegate)
        {
            this.@delegate = @delegate;
        }

        public DelegateDeclarationSyntax Declaration
        {
            get { return @delegate.Declaration; }
        }

        public TypeWithSyntax DeclaringType
        {
            get { return TypeWithSyntax.GetType(@delegate.DeclaringType); }
        }

        public int EndLine
        {
            get { return @delegate.EndLine; }
        }

        public int GenericParameterCount
        {
            get { return @delegate.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @delegate.IsGeneric; }
        }

        public string Name
        {
            get { return @delegate.Name; }
        }

        public int StartLine
        {
            get { return @delegate.StartLine; }
        }

        public INestedDelegateSyntax AsInterface()
        {
            return @delegate;
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @delegate.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitNestedDelegate(this);
        }
    }
}
