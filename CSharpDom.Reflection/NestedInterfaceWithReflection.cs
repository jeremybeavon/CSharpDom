using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class NestedInterfaceWithReflection :
        AbstractNestedInterface<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterWithReflection,
            EventWithReflection,
            PropertyWithReflection,
            IndexerWithReflection,
            MethodWithReflection>,
        IBasicTypeWithReflection
    {
        internal NestedInterfaceWithReflection(ITypeWithReflection declaringType, Type type)
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

        public override IReadOnlyCollection<EventWithReflection> Events
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyList<GenericParameterWithReflection> GenericParameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<IndexerWithReflection> Indexers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<MethodWithReflection> Methods
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<PropertyWithReflection> Properties
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
