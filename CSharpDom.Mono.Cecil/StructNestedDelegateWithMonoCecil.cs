using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Mono.Cecil.Internal;

namespace CSharpDom.Mono.Cecil
{
    public sealed class StructNestedDelegateWithMonoCecil :
        AbstractStructNestedDelegate<
            AttributeWithMonoCecil,
            ITypeWithMonoCecil,
            GenericParameterDeclarationWithMonoCecil,
            ITypeReferenceWithMonoCecil,
            DelegateParameterWithMonoCecil>
    {
        private readonly NestedDelegateWithMonoCecil nestedDelegate;

        internal StructNestedDelegateWithMonoCecil(ITypeWithMonoCecil declaringType, Type type)
        {
            nestedDelegate = new NestedDelegateWithMonoCecil(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeWithMonoCecil> Attributes
        {
            get { return nestedDelegate.Attributes; }
        }

        public override ITypeWithMonoCecil DeclaringType
        {
            get { return nestedDelegate.DeclaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithMonoCecil> GenericParameters
        {
            get { return nestedDelegate.GenericParameters; }
        }

        public override string Name
        {
            get { return nestedDelegate.Name; }
        }

        public override IReadOnlyList<DelegateParameterWithMonoCecil> Parameters
        {
            get { return nestedDelegate.Parameters; }
        }

        public override ITypeReferenceWithMonoCecil ReturnType
        {
            get { return nestedDelegate.ReturnType; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return nestedDelegate.Type.StructMemberVisibility(); }
        }
    }
}
