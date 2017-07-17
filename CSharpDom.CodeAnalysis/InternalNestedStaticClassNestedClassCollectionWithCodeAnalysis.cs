using System.Collections.Generic;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalNestedStaticClassNestedClassCollectionWithCodeAnalysis<TStaticClass> :
        NestedStaticClassNestedClassCollectionWithCodeAnalysis
        where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalNestedStaticClassWithCodeAnalysis<TStaticClass> type;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassNestedClassWithCodeAnalysis,
            ClassDeclarationSyntax> classes;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassNestedAbstractClassWithCodeAnalysis,
            ClassDeclarationSyntax> abstractClasses;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassNestedSealedClassWithCodeAnalysis,
            ClassDeclarationSyntax> sealedClasses;
        private readonly ClassMemberListWrapper<
            TStaticClass,
            NestedStaticClassNestedStaticClassWithCodeAnalysis,
            ClassDeclarationSyntax> staticClasses;
        private readonly NestedStaticClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        internal InternalNestedStaticClassNestedClassCollectionWithCodeAnalysis(
            InternalNestedStaticClassWithCodeAnalysis<TStaticClass> type)
        {
            this.type = type;
            classes = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new NestedStaticClassNestedClassWithCodeAnalysis());
            abstractClasses = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new NestedStaticClassNestedAbstractClassWithCodeAnalysis());
            sealedClasses = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new NestedStaticClassNestedSealedClassWithCodeAnalysis());
            staticClasses = new ClassMemberListWrapper<TStaticClass, NestedStaticClassNestedStaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new NestedStaticClassNestedStaticClassWithCodeAnalysis());
            partialClasses = NestedStaticClassNestedPartialClassCollectionWithCodeAnalysis.Create(type);
        }

        public override ICollection<NestedStaticClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { type.Members.CombineList(nameof(AbstractClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<NestedStaticClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { type.Members.CombineList(nameof(Classes), value.Select(item => item.Syntax)); }
        }

        public override ICollection<NestedStaticClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { type.Members.CombineList(nameof(SealedClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<NestedStaticClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { type.Members.CombineList(nameof(StaticClasses), value.Select(item => item.Syntax)); }
        }

        public override NestedStaticClassNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }
    }
}
