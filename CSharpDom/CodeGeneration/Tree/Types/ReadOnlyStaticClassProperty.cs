using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStaticClassProperty :
        AbstractStaticClassProperty<AttributeGroupNotSupported, IStaticType, ReadOnlyTypeReference, ReadOnlyStaticClassAccessor>
    {
        private readonly StaticClassProperty property;
        private readonly ReadOnlyStaticClassAccessor getAccessor;
        private readonly ReadOnlyTypeReference propertyType;
        private readonly ReadOnlyStaticClassAccessor setAccessor;

        public ReadOnlyStaticClassProperty(StaticClassProperty property)
        {
            this.property = property;
            propertyType = new ReadOnlyTypeReference(property.Type);
            if (property.EmptyAccessors != null)
            {
                getAccessor = new ReadOnlyStaticClassAccessor(property.EmptyAccessors.GetAccessorVisibility);
                setAccessor = new ReadOnlyStaticClassAccessor(property.EmptyAccessors.SetAccessorVisibility);
            }
            else
            {
                if (property.GetAccessor != null)
                {
                    getAccessor = new ReadOnlyStaticClassAccessor(property.GetAccessor);
                }

                if (property.SetAccessor != null)
                {
                    setAccessor = new ReadOnlyStaticClassAccessor(property.SetAccessor);
                }
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IStaticType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyStaticClassAccessor GetAccessor
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

        public override ReadOnlyStaticClassAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override StaticClassMemberVisibilityModifier InheritanceModifier
        {
            get { return property.Visibility; }
        }
    }
}
