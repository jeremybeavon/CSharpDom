using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class InterfaceIndexerWithReflection :
        AbstractInterfaceIndexer<
            AttributeWithReflection,
            IBasicTypeWithReflection,
            ITypeReferenceWithReflection,
            ParameterWithReflection>
    {
        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IBasicTypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool HasGet
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override bool HasSet
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

        public override InterfaceMemberInheritanceModifier InheritanceModifier
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
    }
}
