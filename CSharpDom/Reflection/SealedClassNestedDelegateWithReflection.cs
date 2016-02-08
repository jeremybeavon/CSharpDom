using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class SealedClassNestedDelegateWithReflection :
        AbstractSealedClassNestedDelegate<
            AttributeWithReflection,
            ITypeWithReflection,
            GenericParameterDeclarationWithReflection,
            ITypeReferenceWithReflection,
            ParameterWithReflection>
    {
        private readonly NestedDelegateWithReflection nestedDelegate;

        internal SealedClassNestedDelegateWithReflection(ITypeWithReflection declaringType, Type type)
        {
            nestedDelegate = new NestedDelegateWithReflection(declaringType, type);
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

        public override IReadOnlyList<GenericParameterDeclarationWithReflection> GenericParameters
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

        public override IReadOnlyList<ParameterWithReflection> Parameters
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override ITypeReferenceWithReflection ReturnType
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
