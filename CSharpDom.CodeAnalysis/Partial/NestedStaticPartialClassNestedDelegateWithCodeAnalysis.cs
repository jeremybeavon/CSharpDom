using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassNestedDelegateWithCodeAnalysis :
        EditableStaticClassNestedDelegate<
            AttributeGroupWithCodeAnalysis,
            INestedStaticPartialTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            DelegateParameterWithCodeAnalysis>,
        IHasSyntax<DelegateDeclarationSyntax>,
        IHasNode<DelegateDeclarationSyntax>
    {
        private readonly NestedDelegateWithCodeAnalysis nestedDelegate;

        internal NestedStaticPartialClassNestedDelegateWithCodeAnalysis()
        {
            nestedDelegate = new NestedDelegateWithCodeAnalysis();
        }
        
        public NestedDelegateWithCodeAnalysis Delegate
        {
            get { return nestedDelegate; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedDelegate.Attributes; }
            set { nestedDelegate.Attributes = value; }
        }

        public override INestedStaticPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return nestedDelegate.Delegate.Node.GetParentNode<INestedStaticPartialTypeWithCodeAnalysis>(); }
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
            get { return Syntax.Modifiers.ToClassMemberVisibilityModifier(); }
            set
            {
                DelegateDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithClassMemberVisibilityModifier(value));
            }
        }
        
        INode<DelegateDeclarationSyntax> IHasNode<DelegateDeclarationSyntax>.Node
        {
            get { return nestedDelegate.Delegate.Node; }
        }
    }
}
