using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class NestedDelegateWithLinqExpressions
    {
        private readonly INestedDelegateWithLinqExpressions @delegate;

        public NestedDelegateWithLinqExpressions(INestedDelegateWithLinqExpressions @delegate)
        {
            this.@delegate = @delegate;
        }

        public DelegateDeclarationSyntax Declaration
        {
            get { return @delegate.Declaration; }
        }

        public TypeWithLinqExpressions DeclaringType
        {
            get { return TypeWithLinqExpressions.GetType(@delegate.DeclaringType); }
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

        public INamedTypeSymbol Symbol
        {
            get { return @delegate.Symbol; }
        }

        public INestedDelegateWithLinqExpressions AsInterface()
        {
            return @delegate;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            @delegate.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @delegate.ToString();
        }
    }
}
