using System;
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
        private readonly StructTypeMemberListWrapper<StructConstantWithCodeAnalysis, FieldDeclarationSyntax> constants;
        private readonly StructTypeMemberListWrapper<StructFieldWithCodeAnalysis, FieldDeclarationSyntax> fields;            

        internal StructFieldCollectionWithCodeAnalysis(StructTypeWithCodeAnalysis structType)
        {
            this.structType = structType;
            constants = new StructTypeMemberListWrapper<StructConstantWithCodeAnalysis, FieldDeclarationSyntax>(
                structType.Node,
                () => new StructConstantWithCodeAnalysis(),
                syntax => syntax.IsConstant());
            fields = new StructTypeMemberListWrapper<StructFieldWithCodeAnalysis, FieldDeclarationSyntax>(
                structType.Node,
                () => new StructFieldWithCodeAnalysis(),
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
    }
}
