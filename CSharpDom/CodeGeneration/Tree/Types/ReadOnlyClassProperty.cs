﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassProperty :
        AbstractProperty<AttributeGroupNotSupported, IBasicType, ReadOnlyTypeReference, ReadOnlyClassPropertyAccessor>
    {
        private readonly ClassProperty property;
        private readonly ReadOnlyClassPropertyAccessor getAccessor;
        private readonly ReadOnlyTypeReference propertyType;
        private readonly ReadOnlyClassPropertyAccessor setAccessor;

        public ReadOnlyClassProperty(ClassProperty property)
        {
            this.property = property;
            propertyType = new ReadOnlyTypeReference(property.Type);
            if (property.EmptyAccessors != null)
            {
                getAccessor = new ReadOnlyClassPropertyAccessor(property.EmptyAccessors.GetAccessorVisibility);
                setAccessor = new ReadOnlyClassPropertyAccessor(property.EmptyAccessors.SetAccessorVisibility);
            }
            else
            {
                if (property.GetAccessor != null)
                {
                    getAccessor = new ReadOnlyClassPropertyAccessor(property.GetAccessor);
                }

                if (property.SetAccessor != null)
                {
                    setAccessor = new ReadOnlyClassPropertyAccessor(property.SetAccessor);
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

        public override ReadOnlyClassPropertyAccessor GetAccessor
        {
            get { return getAccessor; }
        }

        public override MemberInheritanceModifier InheritanceModifier
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

        public override ReadOnlyClassPropertyAccessor SetAccessor
        {
            get { return setAccessor; }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return ReadOnlyClass.GetVisibility(property.Visibility); }
        }
    }
}
