using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStaticClassFieldCollectionWithCodeAnalysis<TClass> :
        StaticClassFieldCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalStaticTypeWithCodeAnalysis<TClass> type;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassConstantWithCodeAnalysis,
            FieldDeclarationSyntax> constants;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassFieldWithCodeAnalysis,
            FieldDeclarationSyntax> fields;

        internal InternalStaticClassFieldCollectionWithCodeAnalysis(InternalStaticTypeWithCodeAnalysis<TClass> type)
        {
            this.type = type;
            constants = new ClassMemberListWrapper<TClass, StaticClassConstantWithCodeAnalysis, FieldDeclarationSyntax>(
                type.InternalNode,
                () => new StaticClassConstantWithCodeAnalysis(),
                syntax => syntax.IsConstant());
            fields = new ClassMemberListWrapper<TClass, StaticClassFieldWithCodeAnalysis, FieldDeclarationSyntax>(
                type.InternalNode,
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
