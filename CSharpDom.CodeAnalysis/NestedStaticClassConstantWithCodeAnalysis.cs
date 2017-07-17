using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NestedStaticClassConstantWithCodeAnalysis :
        EditableStaticClassConstant<
            AttributeGroupWithCodeAnalysis,
            INestedStaticTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ConstantWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>,
        IHasNode<FieldDeclarationSyntax>
    {
        private readonly ConstantGroupWithCodeAnalysis constant;

        internal NestedStaticClassConstantWithCodeAnalysis()
        {
            constant = new ConstantGroupWithCodeAnalysis();
        }
        
        public ConstantGroupWithCodeAnalysis Constant
        {
            get { return constant; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return constant.Attributes; }
            set { constant.Attributes = value; }
        }
        
        public override ICollection<ConstantWithCodeAnalysis> Constants
        {
            get { return constant.Constants; }
            set { constant.Constants = value; }
        }

        public override INestedStaticTypeWithCodeAnalysis DeclaringType
        {
            get { return constant.Node.GetParentNode<INestedStaticTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
        {
            get { return constant.FieldType; }
            set { constant.FieldType = value; }
        }
        
        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStaticClassMemberVisibilityModifier(); }
            set
            {
                FieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStaticClassMemberVisibilityModifier(value));
            }
        }

        public FieldDeclarationSyntax Syntax
        {
            get { return constant.Syntax; }
            set { constant.Syntax = value; }
        }
        
        INode<FieldDeclarationSyntax> IHasNode<FieldDeclarationSyntax>.Node
        {
            get { return constant.Node; }
        }
    }
}
