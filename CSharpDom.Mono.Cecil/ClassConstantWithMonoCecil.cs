using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.Mono.Cecil
{
    public sealed class ClassConstantWithMonoCecil :
        AbstractClassConstant<
            AttributeWithMonoCecil,
            IClassTypeWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            IConstant>,
        IConstant
    {
        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
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

        public override IClassTypeWithMonoCecil DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeReferenceWithMonoCecil FieldType
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
