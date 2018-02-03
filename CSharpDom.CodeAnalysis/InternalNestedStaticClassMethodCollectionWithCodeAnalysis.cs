using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalNestedStaticClassMethodCollectionWithCodeAnalysis<TStaticClass> :
        NestedStaticClassMethodCollectionWithCodeAnalysis
        where TStaticClass : class, IHasNode<ClassDeclarationSyntax>
    {
        private readonly InternalNestedStaticClassWithCodeAnalysis<TStaticClass> type;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassMethodWithCodeAnalysis,
            MethodDeclarationSyntax> methods;
        
        internal InternalNestedStaticClassMethodCollectionWithCodeAnalysis(
            InternalNestedStaticClassWithCodeAnalysis<TStaticClass> type)
        {
            this.type = type;
            methods = new ClassMemberListWrapper<TStaticClass, NestedStaticClassMethodWithCodeAnalysis, MethodDeclarationSyntax>(
                type.InternalNode,
                () => new NestedStaticClassMethodWithCodeAnalysis());
        }
        
        public override ICollection<NestedStaticClassMethodWithCodeAnalysis> Methods
        {
            get { return methods; }
            set { type.Members.CombineList(nameof(Methods), value.Select(item => item.Syntax)); }

        }
    }
}
