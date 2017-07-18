﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class NestedStaticPartialClassConstantWithCodeAnalysis :
        EditableStaticClassConstant<
            AttributeGroupWithCodeAnalysis,
            INestedStaticPartialTypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ConstantWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>
    {
        private readonly NestedStaticClassConstantWithCodeAnalysis constant;

        internal NestedStaticPartialClassConstantWithCodeAnalysis(
            NestedStaticClassConstantWithCodeAnalysis constant)
        {
            this.constant = constant;
        }
        
        public NestedStaticClassConstantWithCodeAnalysis Constant
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

        public override INestedStaticPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return constant.Constant.Node.GetParentNode<INestedStaticPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override ITypeReferenceWithCodeAnalysis FieldType
        {
            get { return constant.FieldType; }
            set { constant.FieldType = value; }
        }
        
        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return constant.Visibility; }
            set { constant.Visibility = value; }
        }

        public FieldDeclarationSyntax Syntax
        {
            get { return constant.Syntax; }
            set { constant.Syntax = value; }
        }
    }
}
