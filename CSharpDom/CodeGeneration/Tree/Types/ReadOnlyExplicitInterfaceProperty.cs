using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyExplicitInterfaceProperty :
        AbstractExplicitInterfaceProperty<
            AttributeGroupNotSupported,
            IType,
            ReadOnlyInterfaceReference,
            ReadOnlyTypeReference,
            ReadOnlyAccessor>
    {
        private readonly ExplicitInterfaceProperty property;
        private readonly ReadOnlyInterfaceReference explicitInterface;
        private readonly ReadOnlyAccessor getAccessor;
        private readonly ReadOnlyTypeReference propertyType;
        private readonly ReadOnlyAccessor setAccessor;

        public ReadOnlyExplicitInterfaceProperty(ExplicitInterfaceProperty property)
        {
            this.property = property;
            explicitInterface = new ReadOnlyInterfaceReference(property.ExplicitInterface);
            propertyType = new ReadOnlyTypeReference(property.Type);
            if (property.GetAccessor != null)
            {
                getAccessor = new ReadOnlyAccessor(property.GetAccessor);
            }

            if (property.SetAccessor != null)
            {
                setAccessor = new ReadOnlyAccessor(property.SetAccessor);
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyInterfaceReference ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override ReadOnlyAccessor GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override string Name
        {
            get { return property.Name; }
        }

        public override ReadOnlyTypeReference PropertyType
        {
            get { return propertyType; }
        }

        public override ReadOnlyAccessor SetAccessor
        {
            get { return setAccessor; }
        }
    }
}
