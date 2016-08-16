using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassNestedDelegateWithCodeAnalysis :
        AbstractClassNestedDelegate<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            DelegateParameterWithCodeAnalysis>
    {
        private readonly NestedDelegateWithCodeAnalysis nestedDelegate;

        internal ClassNestedDelegateWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            nestedDelegate = new NestedDelegateWithCodeAnalysis(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedDelegate.Attributes; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return nestedDelegate.DeclaringType; }
        }

        public override IReadOnlyList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return nestedDelegate.GenericParameters; }
        }

        public override string Name
        {
            get { return nestedDelegate.Name; }
        }

        public override IReadOnlyList<DelegateParameterWithCodeAnalysis> Parameters
        {
            get { return nestedDelegate.Parameters; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return nestedDelegate.ReturnType; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedDelegate.TypeDefinition.ClassMemberVisibility(); }
        }
    }
}
