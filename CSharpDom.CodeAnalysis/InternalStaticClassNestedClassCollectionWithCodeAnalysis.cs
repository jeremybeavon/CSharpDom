using System.Collections.Generic;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStaticClassNestedClassCollectionWithCodeAnalysis<TStaticClass> :
        StaticClassNestedClassCollectionWithCodeAnalysis
        where TStaticClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalStaticTypeWithCodeAnalysis<TStaticClass> type;
        private readonly StaticTypeMemberListWrapper<
            TStaticClass,
            StaticClassNestedClassWithCodeAnalysis,
            ClassDeclarationSyntax> classes;
        private readonly StaticTypeMemberListWrapper<
            TStaticClass,
            StaticClassNestedAbstractClassWithCodeAnalysis,
            ClassDeclarationSyntax> abstractClasses;
        private readonly StaticTypeMemberListWrapper<
            TStaticClass,
            StaticClassNestedSealedClassWithCodeAnalysis,
            ClassDeclarationSyntax> sealedClasses;
        private readonly StaticTypeMemberListWrapper<
            TStaticClass,
            StaticClassNestedStaticClassWithCodeAnalysis,
            ClassDeclarationSyntax> staticClasses;
        private readonly StaticClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        internal InternalStaticClassNestedClassCollectionWithCodeAnalysis(
            InternalStaticTypeWithCodeAnalysis<TStaticClass> type)
        {
            this.type = type;
            classes = new StaticTypeMemberListWrapper<TStaticClass, StaticClassNestedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedClassWithCodeAnalysis());
            abstractClasses = new StaticTypeMemberListWrapper<TStaticClass, StaticClassNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedAbstractClassWithCodeAnalysis());
            sealedClasses = new StaticTypeMemberListWrapper<TStaticClass, StaticClassNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedSealedClassWithCodeAnalysis());
            staticClasses = new StaticTypeMemberListWrapper<TStaticClass, StaticClassNestedStaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedStaticClassWithCodeAnalysis());
            partialClasses = StaticClassNestedPartialClassCollectionWithCodeAnalysis.Create(type);
        }

        public override ICollection<StaticClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { type.Members.CombineList(nameof(AbstractClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { type.Members.CombineList(nameof(Classes), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { type.Members.CombineList(nameof(SealedClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { type.Members.CombineList(nameof(StaticClasses), value.Select(item => item.Syntax)); }
        }

        public override StaticClassNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }
    }
}
