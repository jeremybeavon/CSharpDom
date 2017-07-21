using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassConstantWithCodeAnalysis :
        EditableClassConstant<
            AttributeGroupWithCodeAnalysis,
            IAbstractPartialTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ConstantWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>
    {
        private readonly ClassConstantWithCodeAnalysis constant;

        public AbstractPartialClassConstantWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            string name,
            IExpressionWithCodeAnalysis value)
            : this(new ClassConstantWithCodeAnalysis(visibility, type, name, value))
        {
        }

        public AbstractPartialClassConstantWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            params ConstantWithCodeAnalysis[] constants)
            : this(new ClassConstantWithCodeAnalysis(visibility, type, constants))
        {
        }

        internal AbstractPartialClassConstantWithCodeAnalysis(ClassConstantWithCodeAnalysis constant)
        {
            this.constant = constant;
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
        
        public override IAbstractPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return constant.Constant.Node.GetParentNode<IAbstractPartialTypeWithCodeAnalysis>(); }
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

        internal ClassConstantWithCodeAnalysis InternalConstant
        {
            get { return constant; }
        }
    }
}
