using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialStructNestedEnumWithCodeAnalysis :
        EditableStructNestedEnum<
            AttributeGroupWithCodeAnalysis,
            IPartialStructTypeWithCodeAnalysis,
            NestedEnumMemberWithCodeAnalysis>,
        IHasSyntax<EnumDeclarationSyntax>
    {
        private readonly StructNestedEnumWithCodeAnalysis nestedEnum;

        public PartialStructNestedEnumWithCodeAnalysis(
            StructMemberVisibilityModifier visibility,
            string name)
            : this(new StructNestedEnumWithCodeAnalysis(visibility, name))
        {
        }

        internal PartialStructNestedEnumWithCodeAnalysis(StructNestedEnumWithCodeAnalysis nestedEnum)
        {
            this.nestedEnum = nestedEnum;
            nestedEnum.DeclaringTypeFunc = () => DeclaringType.Struct;
        }
        
        public StructNestedEnumWithCodeAnalysis Enum
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

        public override IPartialStructTypeWithCodeAnalysis DeclaringType
        {
            get { return nestedEnum.Enum.Node.GetParentNode<IPartialStructTypeWithCodeAnalysis>(); }
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

        public override StructMemberVisibilityModifier Visibility
        {
            get { return nestedEnum.Visibility; }
            set { nestedEnum.Visibility = value; }
        }
    }
}
