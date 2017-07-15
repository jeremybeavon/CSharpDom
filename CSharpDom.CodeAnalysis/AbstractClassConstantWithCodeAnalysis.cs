using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassConstantWithCodeAnalysis :
        EditableClassConstant<
            AttributeGroupWithCodeAnalysis,
            IAbstractTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ConstantWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>,
        IHasNode<FieldDeclarationSyntax>
    {
        private readonly ClassConstantWithCodeAnalysis constant;

        internal AbstractClassConstantWithCodeAnalysis(ClassConstantWithCodeAnalysis constant = null)
        {
            this.constant = constant ?? new ClassConstantWithCodeAnalysis();
        }
        
        public ConstantGroupWithCodeAnalysis Constant
        {
            get { return constant.Constant; }
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
        
        public override IAbstractTypeWithCodeAnalysis DeclaringType
        {
            get { return constant.Constant.Node.GetParentNode<IAbstractTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
        {
            get { return constant.FieldType; }
            set { constant.FieldType = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return constant.Visibility; }
            set { constant.Visibility = value; }
        }

        public FieldDeclarationSyntax Syntax
        {
            get { return constant.Syntax; }
            set { constant.Syntax = value; }
        }
        
        INode<FieldDeclarationSyntax> IHasNode<FieldDeclarationSyntax>.Node
        {
            get { return constant.Constant.Node; }
        }

        internal ClassConstantWithCodeAnalysis InternalConstant
        {
            get { return constant; }
        }
    }
}
