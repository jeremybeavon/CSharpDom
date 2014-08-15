using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public sealed class NestedStructWithReflection : TypeWithReflection
    {
        private readonly INestedStructWithReflection @struct;

        public NestedStructWithReflection(INestedStructWithReflection @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public IReadOnlyCollection<NestedStructDeclarationWithReflection> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedStructDeclarationWithReflection, INestedStructDeclarationWithReflection>(
                    @struct.Declarations,
                    declaration => new NestedStructDeclarationWithReflection(declaration));
            }
        }

        public TypeWithReflection DeclaringType
        {
            get { return GetType(@struct.DeclaringType); }
        }

        public int GenericParameterCount
        {
            get { return @struct.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @struct.IsGeneric; }
        }

        public string Name
        {
            get { return @struct.Name; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @struct.Symbol; }
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @struct.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @struct.ToString();
        }
    }
}
