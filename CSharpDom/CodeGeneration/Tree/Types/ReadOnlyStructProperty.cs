using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructProperty :
        AbstractStructProperty<AttributeGroupNotSupported, IStructType, ReadOnlyTypeReference, ReadOnlyStructAccessor>
    {
        private readonly StructProperty property;
        private readonly ReadOnlyStructAccessor getAccessor;
        private readonly ReadOnlyTypeReference propertyType;
        private readonly ReadOnlyStructAccessor setAccessor;

        public ReadOnlyStructProperty(StructProperty property)
        {
            this.property = property;
            propertyType = new ReadOnlyTypeReference(property.Type);
            if (property.EmptyAccessors != null)
            {
                getAccessor = new ReadOnlyStructAccessor(property.EmptyAccessors.GetAccessorVisibility);
                setAccessor = new ReadOnlyStructAccessor(property.EmptyAccessors.SetAccessorVisibility);
            }
            else
            {
                if (property.GetAccessor != null)
                {
                    getAccessor = new ReadOnlyStructAccessor(property.GetAccessor);
                }

                if (property.SetAccessor != null)
                {
                    setAccessor = new ReadOnlyStructAccessor(property.SetAccessor);
                }
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IStructType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyStructAccessor GetAccessor
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

        public override ReadOnlyStructAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return property.Visibility; }
        }

        public override StructMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
