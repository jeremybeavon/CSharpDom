using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStaticClassFieldCollectionWithCodeAnalysis<TStaticClass> :
        StaticClassFieldCollectionWithCodeAnalysis
        where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalStaticTypeWithCodeAnalysis<TStaticClass> type;
        private readonly StaticTypeMemberListWrapper<
            TStaticClass,
            StaticClassConstantWithCodeAnalysis,
            FieldDeclarationSyntax> constants;
        private readonly StaticTypeMemberListWrapper<
            TStaticClass,
            StaticClassFieldWithCodeAnalysis,
            FieldDeclarationSyntax> fields;

        internal InternalStaticClassFieldCollectionWithCodeAnalysis(InternalStaticTypeWithCodeAnalysis<TStaticClass> type)
        {
            this.type = type;
            constants = new StaticTypeMemberListWrapper<TStaticClass, StaticClassConstantWithCodeAnalysis, FieldDeclarationSyntax>(
                type.Node,
                () => new StaticClassConstantWithCodeAnalysis(),
                syntax => syntax.IsConstant());
            fields = new StaticTypeMemberListWrapper<TStaticClass, StaticClassFieldWithCodeAnalysis, FieldDeclarationSyntax>(
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
