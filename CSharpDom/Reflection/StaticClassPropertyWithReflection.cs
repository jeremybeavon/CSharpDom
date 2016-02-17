using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassPropertyWithReflection :
        AbstractStaticClassProperty<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            StaticClassAccessorWithReflection>
    {
        private readonly PropertyWithReflection property;
        private readonly StaticClassAccessorWithReflection getAccessor;
        private readonly StaticClassAccessorWithReflection setAccessor;

        internal StaticClassPropertyWithReflection(ITypeWithReflection declaringType, PropertyInfo property)
        {
            this.property = new PropertyWithReflection(declaringType, property);
            if (this.property.GetAccessor != null)
            {
                getAccessor = new StaticClassAccessorWithReflection(this, this.property.GetAccessor);
            }

            if (this.property.SetAccessor != null)
            {
                setAccessor = new StaticClassAccessorWithReflection(this, this.property.SetAccessor);
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

        public override StaticClassAccessorWithReflection GetAccessor
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

        public override StaticClassAccessorWithReflection SetAccessor
        {
            get { return setAccessor; }
        }

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return property.PropertyInfo.StaticClassVisibility(); }
        }
    }
}
