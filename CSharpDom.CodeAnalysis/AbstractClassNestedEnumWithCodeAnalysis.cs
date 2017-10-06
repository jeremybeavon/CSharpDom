using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AbstractClassNestedEnumWithCodeAnalysis :
        EditableClassNestedEnum<
            AttributeGroupWithCodeAnalysis,
            IAbstractTypeWithCodeAnalysis,
            NestedEnumMemberWithCodeAnalysis>,
        IHasSyntax<EnumDeclarationSyntax>,
        IHasNode<EnumDeclarationSyntax>
    {
        private readonly ClassNestedEnumWithCodeAnalysis nestedEnum;

        public AbstractClassNestedEnumWithCodeAnalysis(
            ClassMemberVisibilityModifier visibility,
            string name)
            : this(new ClassNestedEnumWithCodeAnalysis(visibility, name))
        {
        }

        internal AbstractClassNestedEnumWithCodeAnalysis(ClassNestedEnumWithCodeAnalysis @enum)
        {
            nestedEnum = @enum;
            nestedEnum.DeclaringTypeFunc = () => DeclaringType.Class;
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

        public override IAbstractTypeWithCodeAnalysis DeclaringType
        {
            get { return DeclaringTypeFunc?.Invoke() ?? nestedEnum.Enum.Node.GetParentNode<IAbstractTypeWithCodeAnalysis>(); }
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

        internal Func<IAbstractTypeWithCodeAnalysis> DeclaringTypeFunc { get; set; }
    }
}
