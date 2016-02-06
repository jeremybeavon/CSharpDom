using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassProperty :
        AbstractClassProperty<AttributeGroupNotSupported, IClassType, ReadOnlyTypeReference, ReadOnlyClassAccessor>
    {
        private readonly ClassProperty property;
        private readonly ReadOnlyClassAccessor getAccessor;
        private readonly ReadOnlyTypeReference propertyType;
        private readonly ReadOnlyClassAccessor setAccessor;

        public ReadOnlyClassProperty(ClassProperty property)
        {
            this.property = property;
            propertyType = new ReadOnlyTypeReference(property.Type);
            if (property.EmptyAccessors != null)
            {
                getAccessor = new ReadOnlyClassAccessor(property.EmptyAccessors.GetAccessorVisibility);
                setAccessor = new ReadOnlyClassAccessor(property.EmptyAccessors.SetAccessorVisibility);
            }
            else
            {
                if (property.GetAccessor != null)
                {
                    getAccessor = new ReadOnlyClassAccessor(property.GetAccessor);
                }

                if (property.SetAccessor != null)
                {
                    setAccessor = new ReadOnlyClassAccessor(property.SetAccessor);
                }
            }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IClassType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyClassAccessor GetAccessor
        {
            get { return getAccessor; }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return ReadOnlyClass.GetInheritanceModifier(property.InheritanceModifier); }
        }

        public override string Name
        {
            get { return property.Name; }
        }

        public override ReadOnlyTypeReference PropertyType
        {
            get { return propertyType; }
        }

        public override ReadOnlyClassAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return ReadOnlyClass.GetVisibility(property.Visibility); }
        }
    }
}
