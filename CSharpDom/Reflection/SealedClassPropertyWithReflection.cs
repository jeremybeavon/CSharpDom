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
            SealedClassAccessorWithReflection>
    {
        private readonly PropertyWithReflection property;

        internal SealedClassPropertyWithReflection(ITypeWithReflection declaringType, PropertyInfo property)
        {
            this.property = new PropertyWithReflection(declaringType, property);
        }

        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override SealedClassAccessorWithReflection GetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeReferenceWithReflection PropertyType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override SealedClassAccessorWithReflection SetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override SealedClassMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
