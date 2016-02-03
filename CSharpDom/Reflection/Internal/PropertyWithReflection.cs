using CSharpDom.BaseClasses;
using System;
using System.Reflection;
using System.Collections.Generic;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class PropertyWithReflection :
        AbstractClassProperty<AttributeWithReflection, ITypeWithReflection, ITypeReferenceWithReflection, AccessorWithReflection>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithReflection declaringType;
        private readonly PropertyInfo property;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithReflection propertyType;
        private readonly AccessorWithReflection getAccessor;
        private readonly AccessorWithReflection setAccessor;

        internal PropertyWithReflection(ITypeWithReflection declaringType, PropertyInfo property)
        {
            this.declaringType = declaringType;
            this.property = property;
            attributes = new Lazy<Attributes>(() => new Attributes(property));
            propertyType = TypeReferenceWithReflectionFactory.CreateReference(property.PropertyType);
            if (property.GetMethod != null)
            {
                getAccessor = new AccessorWithReflection(this, property.GetMethod);
            }

            if (property.SetMethod != null)
            {
                setAccessor = new AccessorWithReflection(this, property.SetMethod);
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return attributes.Value.AttributesWithReflection; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return declaringType; }
        }

        public override AccessorWithReflection GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return property.InheritanceModifier(); }
        }

        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithReflection PropertyType
        {
            get { return propertyType; }
        }

        public override AccessorWithReflection SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return property.ClassVisibility(); }
        }
        
       /* public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitPropertyWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
