﻿using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class AbstractPartialClassNestedEnumWithCodeAnalysis :
        EditableClassNestedEnum<
            AttributeGroupWithCodeAnalysis,
            IAbstractPartialTypeWithCodeAnalysis,
            NestedEnumMemberWithCodeAnalysis>,
        IHasSyntax<EnumDeclarationSyntax>
    {
        private readonly AbstractClassNestedEnumWithCodeAnalysis nestedEnum;

        public AbstractPartialClassNestedEnumWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            string name)
            : this(new AbstractClassNestedEnumWithCodeAnalysis(visibility, name))
        {
        }

        internal AbstractPartialClassNestedEnumWithCodeAnalysis(AbstractClassNestedEnumWithCodeAnalysis @enum)
        {
            nestedEnum = @enum;
            nestedEnum.DeclaringTypeFunc = () => DeclaringType.Class;
        }
        
        public AbstractClassNestedEnumWithCodeAnalysis Enum
        {
            get { return nestedEnum; }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedEnum.Attributes; }
            set { nestedEnum.Attributes = value; }
        }

        public override EnumBaseType BaseType
        {
            get { return nestedEnum.BaseType; }
            set { nestedEnum.BaseType = value; }
        }

        public override IAbstractPartialTypeWithCodeAnalysis DeclaringType
        {
            get { return nestedEnum.Enum.Enum.Node.GetParent<IAbstractPartialTypeWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override IList<NestedEnumMemberWithCodeAnalysis> EnumMembers
        {
            get { return nestedEnum.EnumMembers; }
            set { nestedEnum.EnumMembers = value; }
        }

        public override string Name
        {
            get { return nestedEnum.Name; }
            set { nestedEnum.Name = value; }
        }

        public EnumDeclarationSyntax Syntax
        {
            get { return nestedEnum.Syntax; }
            set { nestedEnum.Syntax = value; }
        }

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return nestedEnum.Visibility; }
            set { nestedEnum.Visibility = value; }
        }
    }
}
