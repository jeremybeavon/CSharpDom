using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class ClassPropertyWithReflection :
        AbstractClassProperty<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            ClassAccessorWithReflection>
    {
        private readonly PropertyWithReflection property;
        private readonly IInternalTypeWithReflection declaringType;
        private readonly ClassAccessorWithReflection getAccessor;
        private readonly ClassAccessorWithReflection setAccessor;

        internal ClassPropertyWithReflection(IInternalTypeWithReflection declaringType, PropertyInfo propertyInfo)
        {
            property = new PropertyWithReflection(declaringType, propertyInfo);
            this.declaringType = declaringType;
            if (property.GetAccessor != null)
            {
                getAccessor = new ClassAccessorWithReflection(this, property.GetAccessor);
            }

            if (property.SetAccessor != null)
            {
                setAccessor = new ClassAccessorWithReflection(this, property.SetAccessor);
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

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return property.PropertyInfo.InheritanceModifier(declaringType); }
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
