using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class NestedInterfaceWithReflection :
        AbstractClassNestedInterface<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            InterfaceReferenceWithReflection,
            InterfaceEventWithReflection,
            InterfacePropertyWithReflection,
            InterfaceIndexerWithReflection,
            InterfaceMethodWithReflection>,
        IBasicTypeWithReflection/*,
        IHasType,
        IVisitable<IReflectionVisitor>*/
    {
        private readonly ITypeWithReflection declaringType;
        private readonly Type type;
        private readonly BasicTypeWithReflection basicType;

        internal NestedInterfaceWithReflection(ITypeWithReflection declaringType, Type type)
        {
            this.declaringType = declaringType;
            this.type = type;
            basicType = new BasicTypeWithReflection(this, type);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return basicType.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public Type Type
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

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
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

        public override string Name
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

        public override IReadOnlyCollection<InterfaceIndexerWithReflection> Indexers
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

        public override IReadOnlyCollection<InterfacePropertyWithReflection> Properties
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /*public override IReadOnlyCollection<EventWithReflection> Events
        {
            get { return basicType.Events; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
        {
            get { return basicType.GenericParameters; }
        }

        public override IReadOnlyCollection<IndexerWithReflection> Indexers
        {
            get { return basicType.Indexers; }
        }

        public override IReadOnlyCollection<InterfaceReferenceWithReflection> Interfaces
        {
            get { return basicType.Interfaces; }
        }

        public override IReadOnlyCollection<MethodWithReflection> Methods
        {
            get { return basicType.Methods; }
        }

        public override string Name
        {
            get { return type.Name; }
        }

        public override IReadOnlyCollection<PropertyWithReflection> Properties
        {
            get { return basicType.Properties; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return type.NestedVisibility(); }
        }

        public Type Type
        {
            get { return type; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNestedInterfaceWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
