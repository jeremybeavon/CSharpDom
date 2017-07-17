using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassFieldCollectionWithCodeAnalysis :
        EditableStaticClassFieldCollection<StaticClassFieldWithCodeAnalysis, StaticClassConstantWithCodeAnalysis>
    {
        private readonly StaticClassWithCodeAnalysis type;
        private readonly StaticClassMemberListWrapper<
            StaticClassConstantWithCodeAnalysis,
            FieldDeclarationSyntax> constants;
        private readonly StaticClassMemberListWrapper<
            StaticClassFieldWithCodeAnalysis,
            FieldDeclarationSyntax> fields;

        internal StaticClassFieldCollectionWithCodeAnalysis(StaticClassWithCodeAnalysis type)
        {
            this.type = type;
            constants = new StaticClassMemberListWrapper<StaticClassConstantWithCodeAnalysis, FieldDeclarationSyntax>(
                type.Node,
                () => new StaticClassConstantWithCodeAnalysis(),
                syntax => syntax.IsConstant());
            fields = new StaticClassMemberListWrapper<StaticClassFieldWithCodeAnalysis, FieldDeclarationSyntax>(
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
