using System.Collections.Generic;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalNestedStaticClassFieldCollectionWithCodeAnalysis<TStaticClass> :
        NestedStaticClassFieldCollectionWithCodeAnalysis
        where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalNestedStaticClassWithCodeAnalysis<TStaticClass> type;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassConstantWithCodeAnalysis,
            FieldDeclarationSyntax> constants;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassFieldWithCodeAnalysis,
            FieldDeclarationSyntax> fields;

        internal InternalNestedStaticClassFieldCollectionWithCodeAnalysis(
            InternalNestedStaticClassWithCodeAnalysis<TStaticClass> type)
        {
            this.type = type;
            constants = new ClassMemberListWrapper<TStaticClass, NestedStaticClassConstantWithCodeAnalysis, FieldDeclarationSyntax>(
                type.Node,
                () => new NestedStaticClassConstantWithCodeAnalysis(),
                syntax => syntax.IsConstant());
            fields = new ClassMemberListWrapper<TStaticClass, NestedStaticClassFieldWithCodeAnalysis, FieldDeclarationSyntax>(
                type.Node,
                () => new NestedStaticClassFieldWithCodeAnalysis(),
                syntax => !syntax.IsConstant());
        }
        
        public override ICollection<NestedStaticClassConstantWithCodeAnalysis> Constants
        {
            get { return constants; }
            set { type.Members.CombineList(nameof(Constants), value.Select(item => item.Syntax)); }
        }

        public override ICollection<NestedStaticClassFieldWithCodeAnalysis> Fields
        {
            get { return fields; }
            set { type.Members.CombineList(nameof(Fields), value.Select(item => item.Syntax)); }
        }
    }
}
