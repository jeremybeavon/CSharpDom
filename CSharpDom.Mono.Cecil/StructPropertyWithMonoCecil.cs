using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Cil;
using CSharpDom.Mono.Cecil.Internal;
using System.Reflection;
using Mono.Cecil;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructPropertyWithMonoCecil :
        AbstractStructProperty<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            StructAccessorWithMonoCecil>
    {
        private readonly PropertyWithMonoCecil property;
        private readonly StructAccessorWithMonoCecil getAccessor;
        private readonly StructAccessorWithMonoCecil setAccessor;

        internal StructPropertyWithMonoCecil(ITypeWithMonoCecil declaringType, PropertyDefinition property)
        {
            this.property = new PropertyWithMonoCecil(declaringType, property);
            if (this.property.GetAccessor != null)
            {
                getAccessor = new StructAccessorWithMonoCecil(this, this.property.GetAccessor);
            }

            if (this.property.SetAccessor != null)
            {
                setAccessor = new StructAccessorWithMonoCecil(this, this.property.SetAccessor);
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

        public override StructAccessorWithMonoCecil GetAccessor
        {
            get { return getAccessor; }
        }

        public override string Name
        {
            get { return property.Name; }
        }

        public override ITypeReferenceWithMonoCecil PropertyType
        {
            get { return property.PropertyType; }
        }

        public override StructAccessorWithMonoCecil SetAccessor
        {
            get { return setAccessor; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return property.PropertyDefinition.StructVisibility(); }
        }
    }
}
