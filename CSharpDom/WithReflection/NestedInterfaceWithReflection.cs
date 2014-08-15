using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public sealed class NestedInterfaceWithReflection : BasicTypeWithReflection
    {
        private readonly INestedInterfaceWithReflection @interface;

        public NestedInterfaceWithReflection(INestedInterfaceWithReflection @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public IReadOnlyCollection<NestedInterfaceDeclarationWithReflection> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedInterfaceDeclarationWithReflection, INestedInterfaceDeclarationWithReflection>(
                    @interface.Declarations,
                    declaration => new NestedInterfaceDeclarationWithReflection(declaration));
            }
        }

        public TypeWithReflection DeclaringType
        {
            get { return TypeWithReflection.GetType(@interface.DeclaringType); }
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

        public INamedTypeSymbol Symbol
        {
            get { return @interface.Symbol; }
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
