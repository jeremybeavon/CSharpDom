using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SealedClassNestedEnumWithCodeAnalysis :
        EditableClassNestedEnum<
            AttributeGroupWithCodeAnalysis,
            ISealedTypeWithCodeAnalysis,
            NestedEnumMemberWithCodeAnalysis>,
        IHasSyntax<EnumDeclarationSyntax>,
        IHasNode<EnumDeclarationSyntax>
    {
        private readonly ClassNestedEnumWithCodeAnalysis nestedEnum;

        internal SealedClassNestedEnumWithCodeAnalysis(ClassNestedEnumWithCodeAnalysis @enum)
        {
            nestedEnum = @enum ?? new ClassNestedEnumWithCodeAnalysis();
        }
        
        public NestedEnumWithCodeAnalysis Enum
        {
            get { return nestedEnum.Enum; }
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

        public override ISealedTypeWithCodeAnalysis DeclaringType
        {
            get { return nestedEnum.Enum.Node.GetParentNode<ISealedTypeWithCodeAnalysis>(); }
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
        
        INode<EnumDeclarationSyntax> IHasNode<EnumDeclarationSyntax>.Node
        {
            get { return nestedEnum.Enum.Node; }
        }

        internal ClassNestedEnumWithCodeAnalysis InternalEnum
        {
            get { return nestedEnum; }
        }
    }
}
