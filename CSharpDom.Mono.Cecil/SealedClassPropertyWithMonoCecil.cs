using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public sealed class SealedClassPropertyWithMonoCecil :
        AbstractSealedClassProperty<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            ClassAccessorWithMonoCecil>
    {
        private readonly PropertyWithMonoCecil property;
        private readonly IInternalTypeWithMonoCecil declaringType;
        private readonly ClassAccessorWithMonoCecil getAccessor;
        private readonly ClassAccessorWithMonoCecil setAccessor;

        internal SealedClassPropertyWithMonoCecil(IInternalTypeWithMonoCecil declaringType, PropertyInfo property)
        {
            this.property = new PropertyWithMonoCecil(declaringType, property);
            this.declaringType = declaringType;
            if (this.property.GetAccessor != null)
            {
                getAccessor = new ClassAccessorWithMonoCecil(this, this.property.GetAccessor);
            }

            if (this.property.SetAccessor != null)
            {
                setAccessor = new ClassAccessorWithMonoCecil(this, this.property.SetAccessor);
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

        public override SealedClassMemberInheritanceModifier InheritanceModifier
        {
            get { return property.PropertyInfo.SealedClassInheritanceModifier(declaringType); }
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
