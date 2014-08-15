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
    public sealed class NestedDelegateWithReflection
    {
        private readonly INestedDelegateWithReflection @delegate;

        public NestedDelegateWithReflection(INestedDelegateWithReflection @delegate)
        {
            this.@delegate = @delegate;
        }

        public DelegateDeclarationSyntax Declaration
        {
            get { return @delegate.Declaration; }
        }

        public TypeWithReflection DeclaringType
        {
            get { return TypeWithReflection.GetType(@delegate.DeclaringType); }
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

        public INestedDelegateWithReflection AsInterface()
        {
            return @delegate;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @delegate.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @delegate.ToString();
        }
    }
}
