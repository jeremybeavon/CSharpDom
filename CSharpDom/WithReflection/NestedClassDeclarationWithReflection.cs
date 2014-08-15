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
    public sealed class NestedClassDeclarationWithReflection : TypeWithReflection
    {
        private readonly INestedClassDeclarationWithReflection @class;

        public NestedClassDeclarationWithReflection(INestedClassDeclarationWithReflection @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public NestedClassWithReflection CompositeType
        {
            get { return new NestedClassWithReflection(@class.CompositeType); }
        }

        public ClassDeclarationSyntax Declaration
        {
            get { return @class.Declaration; }
        }

        public TypeWithReflection DeclaringType
        {
            get { return TypeWithReflection.GetType(@class.DeclaringType); }
        }

        public int GenericParameterCount
        {
            get { return @class.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @class.IsGeneric; }
        }

        public string Name
        {
            get { return @class.Name; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @class.Symbol; }
        }

        public INestedClassDeclarationWithReflection AsInterface()
        {
            return @class;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @class.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @class.ToString();
        }
    }
}
