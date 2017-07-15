using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStructFieldCollectionWithCodeAnalysis<TStruct> :
        StructFieldCollectionWithCodeAnalysis
        where TStruct : class, IHasSyntax<StructDeclarationSyntax>
    {
        private readonly InternalStructTypeWithCodeAnalysis<TStruct> structType;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructConstantWithCodeAnalysis,
            FieldDeclarationSyntax> constants;
        private readonly StructTypeMemberListWrapper<
            TStruct,
            StructFieldWithCodeAnalysis,
            FieldDeclarationSyntax> fields;            

        internal InternalStructFieldCollectionWithCodeAnalysis(InternalStructTypeWithCodeAnalysis<TStruct> structType)
        {
            this.structType = structType;
            constants = new StructTypeMemberListWrapper<TStruct, StructConstantWithCodeAnalysis, FieldDeclarationSyntax>(
                structType.Node,
                () => new StructConstantWithCodeAnalysis(),
                syntax => syntax.IsConstant());
            fields = new StructTypeMemberListWrapper<TStruct, StructFieldWithCodeAnalysis, FieldDeclarationSyntax>(
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
