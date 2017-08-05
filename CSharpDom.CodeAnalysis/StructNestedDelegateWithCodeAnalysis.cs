using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedDelegateWithCodeAnalysis :
        EditableStructNestedDelegate<
            AttributeGroupWithCodeAnalysis,
            IStructTypeWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            DelegateParameterWithCodeAnalysis>,
        IHasSyntax<DelegateDeclarationSyntax>,
        IHasNode<DelegateDeclarationSyntax>
    {
        private readonly NestedDelegateWithCodeAnalysis nestedDelegate;

        public StructNestedDelegateWithCodeAnalysis(
            StructMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis returnType,
            string name,
            IEnumerable<DelegateParameterWithCodeAnalysis> parameters)
            : this()
        {
            Syntax = SyntaxFactory.DelegateDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithStructMemberVisibilityModifier(visibility),
                returnType.Syntax,
                SyntaxFactory.Identifier(name),
                null,
                SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList(parameters.Select(parameter => parameter.Syntax))),
                default(SyntaxList<TypeParameterConstraintClauseSyntax>));
        }

        internal StructNestedDelegateWithCodeAnalysis()
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

        public override IStructTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? nestedDelegate.Delegate.Node.GetParentNode<IStructTypeWithCodeAnalysis>(); }
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

        public override StructMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStructMemberVisibilityModifier(); }
            set
            {
                DelegateDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberVisibilityModifier(value));
            }
        }
        
        INode<DelegateDeclarationSyntax> IHasNode<DelegateDeclarationSyntax>.Node
        {
            get { return nestedDelegate.Delegate.Node; }
        }

        internal Func<IStructTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
