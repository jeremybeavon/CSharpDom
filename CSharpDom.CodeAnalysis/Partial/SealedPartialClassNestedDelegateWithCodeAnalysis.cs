using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class SealedPartialClassNestedDelegateWithCodeAnalysis :
        EditableClassNestedDelegate<
            AttributeGroupWithCodeAnalysis,
            ISealedPartialTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            DelegateParameterWithCodeAnalysis>,
        IHasSyntax<DelegateDeclarationSyntax>
    {
        private readonly SealedClassNestedDelegateWithCodeAnalysis nestedDelegate;

        public SealedPartialClassNestedDelegateWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis returnType,
            string name,
            IEnumerable<DelegateParameterWithCodeAnalysis> parameters)
            : this(new SealedClassNestedDelegateWithCodeAnalysis(visibility, returnType, name, parameters))
        {
        }

        internal SealedPartialClassNestedDelegateWithCodeAnalysis(SealedClassNestedDelegateWithCodeAnalysis @delegate)
        {
            nestedDelegate = @delegate;
            nestedDelegate.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public SealedClassNestedDelegateWithCodeAnalysis Delegate
        {
            get { return nestedDelegate; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedDelegate.Attributes; }
            set { nestedDelegate.Attributes = value; }
        }

        public override ISealedPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return nestedDelegate.Delegate.Delegate.Delegate.Node.GetParentNode<ISealedPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return nestedDelegate.GenericParameters; }
            set { nestedDelegate.GenericParameters = value; }
        }

        public override string Name
        {
            get { return nestedDelegate.Name; }
            set { nestedDelegate.Name = value; }
        }

        public override IList<DelegateParameterWithCodeAnalysis> Parameters
        {
            get { return nestedDelegate.Parameters; }
            set { nestedDelegate.Parameters = value; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return nestedDelegate.ReturnType; }
            set { nestedDelegate.ReturnType = value; }
        }

        public DelegateDeclarationSyntax Syntax
        {
            get { return nestedDelegate.Syntax; }
            set { nestedDelegate.Syntax = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedDelegate.Visibility; }
            set { nestedDelegate.Visibility = value; }
        }
    }
}
