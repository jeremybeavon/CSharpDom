using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassPropertyWithReflection :
        AbstractSealedClassProperty<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            ClassAccessorWithReflection>
    {
        private readonly PropertyWithReflection property;
        private readonly IInternalTypeWithReflection declaringType;
        private readonly ClassAccessorWithReflection getAccessor;
        private readonly ClassAccessorWithReflection setAccessor;

        internal SealedClassPropertyWithReflection(IInternalTypeWithReflection declaringType, PropertyInfo property)
        {
            this.property = new PropertyWithReflection(declaringType, property);
            this.declaringType = declaringType;
            if (this.property.GetAccessor != null)
            {
                getAccessor = new ClassAccessorWithReflection(this, this.property.GetAccessor);
            }

            if (this.property.SetAccessor != null)
            {
                setAccessor = new ClassAccessorWithReflection(this, this.property.SetAccessor);
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

        public override ClassAccessorWithReflection GetAccessor
        {
            get { return getAccessor; }
        }

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return property.PropertyInfo.SealedClassInheritanceModifier(declaringType); }
        }

        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithReflection PropertyType
        {
            get { return property.PropertyType; }
        }

        public override ClassAccessorWithReflection SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return property.PropertyInfo.ClassVisibility(); }
        }
    }
}
