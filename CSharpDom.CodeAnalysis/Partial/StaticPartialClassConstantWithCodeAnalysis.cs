using System;
using System.Collections.Generic;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpDom.BaseClasses.Editable;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassConstantWithCodeAnalysis :
        EditableStaticClassConstant<
            AttributeGroupWithCodeAnalysis,
            StaticPartialClassWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            ConstantWithCodeAnalysis>,
        IHasSyntax<FieldDeclarationSyntax>
    {
        private readonly StaticClassConstantWithCodeAnalysis constant;

        public StaticPartialClassConstantWithCodeAnalysis(
            StaticClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            string name,
            IExpressionWithCodeAnalysis value)
            : this(new StaticClassConstantWithCodeAnalysis(visibility, type, name, value))
        {
        }

        public StaticPartialClassConstantWithCodeAnalysis(
            StaticClassMemberVisibilityModifier visibility,
            ITypeReferenceWithCodeAnalysis type,
            params ConstantWithCodeAnalysis[] constants)
            : this(new StaticClassConstantWithCodeAnalysis(visibility, type, constants))
        {
        }

        internal StaticPartialClassConstantWithCodeAnalysis(StaticClassConstantWithCodeAnalysis constant)
        {
            this.constant = constant;
            constant.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public StaticClassConstantWithCodeAnalysis Constant
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

        public override StaticPartialClassWithCodeAnalysis DeclaringType
        {
            get { return constant.Constant.Node.GetParentNode<StaticPartialClassWithCodeAnalysis>(); }
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
    }
}
