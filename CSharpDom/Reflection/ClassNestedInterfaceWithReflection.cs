using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class ClassNestedInterfaceWithReflection :
        AbstractClassNestedInterface<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            InterfaceReferenceWithReflection,
            InterfaceEventWithReflection,
            InterfacePropertyWithReflection,
            InterfaceIndexerWithReflection,
            InterfaceMethodWithReflection>
    {
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

        public override IReadOnlyCollection<InterfaceEventWithReflection> Events
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<InterfaceIndexerWithReflection> Indexers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithReflection> Interfaces
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<InterfaceMethodWithReflection> Methods
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

        public override IReadOnlyCollection<InterfacePropertyWithReflection> Properties
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
