using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.Reflection
{
    public sealed class StaticClassConstantWithReflection :
        AbstractStaticClassConstant<
            AttributeWithReflection,
            ITypeWithReflection,
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

        public override ITypeWithReflection DeclaringType
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

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
