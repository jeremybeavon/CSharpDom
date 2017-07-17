using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassFieldCollectionWithCodeAnalysis :
        EditableStaticClassFieldCollection<StaticPartialClassFieldWithCodeAnalysis, StaticPartialClassConstantWithCodeAnalysis>
    {
        private readonly StaticPartialClassWithCodeAnalysis type;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassConstantWithCodeAnalysis,
            FieldDeclarationSyntax> constants;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassFieldWithCodeAnalysis,
            FieldDeclarationSyntax> fields;

        internal StaticPartialClassFieldCollectionWithCodeAnalysis(StaticPartialClassWithCodeAnalysis type)
        {
            this.type = type;
            constants = new StaticPartialClassMemberListWrapper<StaticPartialClassConstantWithCodeAnalysis, FieldDeclarationSyntax>(
                type.Node,
                () => new StaticPartialClassConstantWithCodeAnalysis(),
                syntax => syntax.IsConstant());
            fields = new StaticPartialClassMemberListWrapper<StaticPartialClassFieldWithCodeAnalysis, FieldDeclarationSyntax>(
                type.Node,
                () => new StaticPartialClassFieldWithCodeAnalysis(),
                syntax => !syntax.IsConstant());
        }

        public override ICollection<StaticPartialClassConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { type.Members.CombineList(nameof(Constants), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticPartialClassFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { type.Members.CombineList(nameof(Fields), value.Select(item => item.Syntax)); }
        }
    }
}
