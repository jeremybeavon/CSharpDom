using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructNestedEnumWithCodeAnalysis :
        AbstractStructNestedEnum<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            NestedEnumMemberWithCodeAnalysis>
    {
        private readonly NestedEnumWithCodeAnalysis nestedEnum;

        internal StructNestedEnumWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, TypeDefinition type)
        {
            nestedEnum = new NestedEnumWithCodeAnalysis(declaringType, type);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return nestedEnum.Attributes; }
        }

        public override EnumBaseType BaseType
        {
            get { return nestedEnum.BaseType; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return nestedEnum.DeclaringType; }
        }

        public override IReadOnlyList<NestedEnumMemberWithCodeAnalysis> EnumMembers
        {
            get { return nestedEnum.EnumMembers; }
        }

        public override string Name
        {
            get { return nestedEnum.Name; }
        }

        public override StructMemberVisibilityModifier Visibility
        {
            get { return nestedEnum.TypeDefinition.StructMemberVisibility(); }
        }
    }
}
