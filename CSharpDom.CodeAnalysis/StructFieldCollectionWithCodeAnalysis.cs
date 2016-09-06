﻿using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StructFieldCollectionWithCodeAnalysis :
        EditableStructFieldCollection<StructFieldWithCodeAnalysis, StructConstantWithCodeAnalysis>
    {
        private readonly StructTypeWithCodeAnalysis structType;
        private readonly StructTypeMemberListWrapper<
            ConstantGroupWithCodeAnalysis,
            StructConstantWithCodeAnalysis,
            FieldDeclarationSyntax> constants;
        private readonly StructTypeMemberListWrapper<
            FieldGroupWithCodeAnalysis,
            StructFieldWithCodeAnalysis,
            FieldDeclarationSyntax> fields;            

        internal StructFieldCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
            constants = new StructTypeMemberListWrapper<ConstantGroupWithCodeAnalysis, StructConstantWithCodeAnalysis, FieldDeclarationSyntax>(
                structType.Node,
                parent => new StructConstantWithCodeAnalysis(parent),
                (child, parent) => child.Constant.StructParent = parent,
                syntax => syntax.IsConstant());
            fields = new StructTypeMemberListWrapper<FieldGroupWithCodeAnalysis, StructFieldWithCodeAnalysis, FieldDeclarationSyntax>(
                structType.Node,
                parent => new StructFieldWithCodeAnalysis(parent),
                (child, parent) => child.Field.StructParent = parent,
                syntax => !syntax.IsConstant());
        }

        public override ICollection<StructConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { structType.Members.CombineList(nameof(Constants), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StructFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { structType.Members.CombineList(nameof(Fields), value.Select(item => item.Syntax)); }
        }

        internal IChildCollection<ConstantGroupWithCodeAnalysis, FieldDeclarationSyntax> ConstantList
        {
            get { return constants; }
        }

        internal IChildCollection<FieldGroupWithCodeAnalysis, FieldDeclarationSyntax> FieldList
        {
            get { return fields; }
        }
    }
}
