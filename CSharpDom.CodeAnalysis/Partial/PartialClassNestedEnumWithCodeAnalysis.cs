using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassNestedEnumWithCodeAnalysis :
        EditableClassNestedEnum<
            AttributeGroupWithCodeAnalysis,
            IPartialClassTypeWithCodeAnalysis,
            NestedEnumMemberWithCodeAnalysis>,
        IHasSyntax<EnumDeclarationSyntax>
    {
        private readonly ClassNestedEnumWithCodeAnalysis nestedEnum;

        public PartialClassNestedEnumWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            string name)
            : this(new ClassNestedEnumWithCodeAnalysis(visibility, name))
        {
        }

        internal PartialClassNestedEnumWithCodeAnalysis(ClassNestedEnumWithCodeAnalysis @enum)
        {
            nestedEnum = @enum;
        }
        
        public ClassNestedEnumWithCodeAnalysis Enum
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

        public override IPartialClassTypeWithCodeAnalysis DeclaringType
        {
            get { return nestedEnum.Enum.Node.GetParentNode<IPartialClassTypeWithCodeAnalysis>(); }
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
