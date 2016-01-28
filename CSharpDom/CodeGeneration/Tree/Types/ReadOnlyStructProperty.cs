using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStructProperty :
        AbstractProperty<AttributeGroupNotSupported, IBasicType, ReadOnlyTypeReference, ReadOnlyStructPropertyAccessor>
    {
        private readonly StructProperty property;
        private readonly ReadOnlyStructPropertyAccessor getAccessor;
        private readonly ReadOnlyTypeReference propertyType;
        private readonly ReadOnlyStructPropertyAccessor setAccessor;

        public ReadOnlyStructProperty(StructProperty property)
        {
            this.property = property;
            propertyType = new ReadOnlyTypeReference(property.Type);
            if (property.EmptyAccessors != null)
            {
                getAccessor = new ReadOnlyStructPropertyAccessor(property.EmptyAccessors.GetAccessorVisibility);
                setAccessor = new ReadOnlyStructPropertyAccessor(property.EmptyAccessors.SetAccessorVisibility);
            }
            else
            {
                if (property.GetAccessor != null)
                {
                    getAccessor = new ReadOnlyStructPropertyAccessor(property.GetAccessor);
                }

                if (property.SetAccessor != null)
                {
                    setAccessor = new ReadOnlyStructPropertyAccessor(property.SetAccessor);
                }
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IBasicType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyStructPropertyAccessor GetAccessor
        {
            get { return getAccessor; }
        }

        public override MemberInheritanceModifier InheritanceModifier
        {
            get { return property.IsStatic ? MemberInheritanceModifier.Static : MemberInheritanceModifier.None; }
        }

        public override string Name
        {
            get { return property.Name; }
        }

        public override ReadOnlyTypeReference PropertyType
        {
            get { return propertyType; }
        }

        public override ReadOnlyStructPropertyAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return ReadOnlyStruct.GetVisibility(property.Visibility); }
        }
    }
}
