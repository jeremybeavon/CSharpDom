using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ExplicitInterfaceIndexerWithReflection :
        AbstractExplicitInterfaceIndexer<
            AttributeWithReflection,
            ITypeWithReflection,
            InterfaceReferenceWithReflection,
            ITypeReferenceWithReflection,
            ParameterWithReflection,
            ClassAccessorWithReflection>
    {
        internal ExplicitInterfaceIndexerWithReflection(ITypeWithReflection declaringType, PropertyInfo indexer)
        {

        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override InterfaceReferenceWithReflection ExplicitInterface
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ClassAccessorWithReflection GetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeReferenceWithReflection IndexerType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ClassAccessorWithReflection SetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
