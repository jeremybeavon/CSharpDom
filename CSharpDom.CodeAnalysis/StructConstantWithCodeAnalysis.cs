using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructConstantWithCodeAnalysis :
        EditableStructConstant<
            AttributeGroupWithCodeAnalysis,
            IStructTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ConstantWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>,
        IHasNode<FieldDeclarationSyntax>
    {
        private readonly ConstantGroupWithCodeAnalysis constant;

        public StructConstantWithCodeAnalysis(
            StructMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            string name,
            IExpressionWithCodeAnalysis value)
            : this(visibility, type, new ConstantWithCodeAnalysis(name, value))
        {
        }

        public StructConstantWithCodeAnalysis(
            StructMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            params ConstantWithCodeAnalysis[] constants)
            : this()
        {
            IEnumerable<VariableDeclaratorSyntax> syntax = constants.Select(constant => constant.Syntax);
            Syntax = SyntaxFactory.FieldDeclaration(
                default(SyntaxList<AttributeListSyntax>),
                default(SyntaxTokenList).WithStructMemberVisibilityModifier(visibility),
                SyntaxFactory.VariableDeclaration(type.Syntax, SyntaxFactory.SeparatedList(syntax)));
        }

        internal StructConstantWithCodeAnalysis()
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

        public override IStructTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? constant.Node.GetParentNode<IStructTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
        {
            get { return constant.FieldType; }
            set { constant.FieldType = value; }
        }
        
        public override StructMemberVisibilityModifier Visibility
        {
            get { return Syntax.Modifiers.ToStructMemberVisibilityModifier(); }
            set
            {
                FieldDeclarationSyntax syntax = Syntax;
                Syntax = syntax.WithModifiers(syntax.Modifiers.WithStructMemberVisibilityModifier(value));
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

        internal Func<IStructTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
