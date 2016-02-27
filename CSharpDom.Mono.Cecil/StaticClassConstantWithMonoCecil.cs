using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Common;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StaticClassConstantWithMonoCecil :
        AbstractStaticClassConstant<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
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

        public override ITypeWithMonoCecil DeclaringType
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

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
