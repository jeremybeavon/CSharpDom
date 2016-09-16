using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassFieldCollectionWithCodeAnalysis :
        EditableStaticClassFieldCollection<StaticClassFieldWithCodeAnalysis, StaticClassConstantWithCodeAnalysis>
    {
        private readonly StaticTypeWithCodeAnalysis type;
        private readonly StaticTypeMemberListWrapper<StaticClassConstantWithCodeAnalysis, FieldDeclarationSyntax> constants;
        private readonly StaticTypeMemberListWrapper<StaticClassFieldWithCodeAnalysis, FieldDeclarationSyntax> fields;

        internal StaticClassFieldCollectionWithCodeAnalysis(StaticTypeWithCodeAnalysis type)
        {
            this.type = type;
            constants = new StaticTypeMemberListWrapper<StaticClassConstantWithCodeAnalysis, FieldDeclarationSyntax>(
                type.Node,
                () => new StaticClassConstantWithCodeAnalysis(),
                syntax => syntax.IsConstant());
            fields = new StaticTypeMemberListWrapper<StaticClassFieldWithCodeAnalysis, FieldDeclarationSyntax>(
                type.Node,
                () => new StaticClassFieldWithCodeAnalysis(),
                syntax => !syntax.IsConstant());
        }
        
        public override ICollection<StaticClassConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { type.Members.CombineList(nameof(Constants), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { type.Members.CombineList(nameof(Fields), value.Select(item => item.Syntax)); }
        }
    }
}
