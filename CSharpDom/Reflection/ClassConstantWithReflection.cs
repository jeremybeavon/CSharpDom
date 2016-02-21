using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.Reflection
{
    public sealed class ClassConstantWithReflection :
        AbstractClassConstant<
            AttributeWithReflection,
            IClassTypeWithReflection,
            ITypeReferenceWithReflection,
            IConstant>,
        IConstant
    {
        public override IReadOnlyCollection<AttributeWithReflection> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IReadOnlyCollection<IConstant> Constants
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IClassTypeWithReflection DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeReferenceWithReflection FieldType
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
