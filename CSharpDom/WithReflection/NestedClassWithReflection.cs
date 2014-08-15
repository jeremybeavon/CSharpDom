using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public sealed class NestedClassWithReflection : TypeWithReflection
    {
        private readonly INestedClassWithReflection @class;

        public NestedClassWithReflection(INestedClassWithReflection @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public IReadOnlyCollection<NestedClassDeclarationWithReflection> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedClassDeclarationWithReflection, INestedClassDeclarationWithReflection>(
                    @class.Declarations,
                    declaration => new NestedClassDeclarationWithReflection(declaration));
            }
        }

        public TypeWithReflection DeclaringType
        {
            get { return GetType(@class.DeclaringType); }
        }

        public NestedDestructorWithReflection Destructor
        {
            get { return @class.Destructor == null ? null : new NestedDestructorWithReflection(@class.Destructor); }
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

        public INestedClassWithReflection AsInterface()
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
