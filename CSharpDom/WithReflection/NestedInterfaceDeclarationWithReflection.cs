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
    public sealed class NestedInterfaceDeclarationWithReflection : BasicTypeWithReflection
    {
        private readonly INestedInterfaceDeclarationWithReflection @interface;

        public NestedInterfaceDeclarationWithReflection(INestedInterfaceDeclarationWithReflection @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public NestedInterfaceWithReflection CompositeType
        {
            get { return new NestedInterfaceWithReflection(@interface.CompositeType); }
        }

        public InterfaceDeclarationSyntax Declaration
        {
            get { return @interface.Declaration; }
        }

        public TypeWithReflection DeclaringType
        {
            get { return TypeWithReflection.GetType(@interface.DeclaringType); }
        }

        public int EndLine
        {
            get { return @interface.EndLine; }
        }

        public int GenericParameterCount
        {
            get { return @interface.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @interface.IsGeneric; }
        }

        public string Name
        {
            get { return @interface.Name; }
        }

        public int StartLine
        {
            get { return @interface.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @interface.Symbol; }
        }

        public INestedInterfaceDeclarationWithReflection AsInterface()
        {
            return @interface;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @interface.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @interface.ToString();
        }
    }
}
