using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassPropertyWithMonoCecil :
        AbstractClassProperty<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            ClassAccessorWithMonoCecil>
    {
        private readonly PropertyWithMonoCecil property;
        private readonly IInternalTypeWithMonoCecil declaringType;
        private readonly ClassAccessorWithMonoCecil getAccessor;
        private readonly ClassAccessorWithMonoCecil setAccessor;

        internal ClassPropertyWithMonoCecil(IInternalTypeWithMonoCecil declaringType, PropertyInfo propertyInfo)
        {
            property = new PropertyWithMonoCecil(declaringType, propertyInfo);
            this.declaringType = declaringType;
            if (property.GetAccessor != null)
            {
                getAccessor = new ClassAccessorWithMonoCecil(this, property.GetAccessor);
            }

            if (property.SetAccessor != null)
            {
                setAccessor = new ClassAccessorWithMonoCecil(this, property.SetAccessor);
            }
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return property.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return property.DeclaringType; }
        }

        public override ClassAccessorWithMonoCecil GetAccessor
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

        public override ITypeReferenceWithMonoCecil PropertyType
        {
            get { return property.PropertyType; }
        }

        public override ClassAccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return property.PropertyInfo.ClassVisibility(); }
        }
    }
}
