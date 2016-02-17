using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class AbstractPropertyWithReflection :
        AbstractAbstractProperty<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            AbstractAccessorWithReflection>
    {
        private readonly PropertyWithReflection property;
        private readonly AbstractAccessorWithReflection getAccessor;
        private readonly AbstractAccessorWithReflection setAccessor;

        internal AbstractPropertyWithReflection(ITypeWithReflection declaringType, PropertyInfo property)
        {
            this.property = new PropertyWithReflection(declaringType, property);
            if (this.property.GetAccessor != null)
            {
                getAccessor = new AbstractAccessorWithReflection(this, this.property.GetAccessor);
            }

            if (this.property.SetAccessor != null)
            {
                setAccessor = new AbstractAccessorWithReflection(this, this.property.SetAccessor);
            }
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get { return property.Attributes; }
        }

        public override ITypeWithReflection DeclaringType
        {
            get { return property.DeclaringType; }
        }

        public override AbstractAccessorWithReflection GetAccessor
        {
            get { return getAccessor; }
        }
        
        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithReflection PropertyType
        {
            get { return property.PropertyType; }
        }

        public override AbstractAccessorWithReflection SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return property.PropertyInfo.ClassVisibility(); }
        }
    }
}
