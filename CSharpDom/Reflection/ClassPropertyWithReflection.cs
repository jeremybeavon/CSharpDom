using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Emit;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class ClassPropertyWithReflection :
        AbstractClassProperty<
            AttributeWithReflection,
            ITypeWithReflection,
            ITypeReferenceWithReflection,
            AccessorWithReflection>
    {
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

        public override AccessorWithReflection GetAccessor
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

        public override AccessorWithReflection SetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
