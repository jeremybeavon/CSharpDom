using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class StructPropertyWithReflection :
        AbstractStructProperty<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            StructAccessorWithReflection>
    {
        private readonly PropertyWithReflection property;
        private readonly StructAccessorWithReflection getAccessor;
        private readonly StructAccessorWithReflection setAccessor;

        internal StructPropertyWithReflection(ITypeWithReflection declaringType, PropertyInfo property)
        {
            this.property = new PropertyWithReflection(declaringType, property);
            if (this.property.GetAccessor != null)
            {
                getAccessor = new StructAccessorWithReflection(this, this.property.GetAccessor);
            }

            if (this.property.SetAccessor != null)
            {
                setAccessor = new StructAccessorWithReflection(this, this.property.SetAccessor);
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

        public override StructAccessorWithReflection GetAccessor
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

        public override StructAccessorWithReflection SetAccessor
        {
            get { return setAccessor; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return property.PropertyInfo.StructVisibility(); }
        }
    }
}
