using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStaticClassNestedClassCollectionWithCodeAnalysis<TClass> :
        StaticClassNestedClassCollectionWithCodeAnalysis
        where TClass : class, IHasSyntax<ClassDeclarationSyntax>
    {
        private readonly InternalStaticTypeWithCodeAnalysis<TClass> type;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassNestedClassWithCodeAnalysis,
            ClassDeclarationSyntax> classes;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassNestedAbstractClassWithCodeAnalysis,
            ClassDeclarationSyntax> abstractClasses;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassNestedSealedClassWithCodeAnalysis,
            ClassDeclarationSyntax> sealedClasses;
        private readonly ClassMemberListWrapper<
            TClass,
            StaticClassNestedStaticClassWithCodeAnalysis,
            ClassDeclarationSyntax> staticClasses;
        private readonly StaticClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        internal InternalStaticClassNestedClassCollectionWithCodeAnalysis(
            InternalStaticTypeWithCodeAnalysis<TClass> type)
        {
            this.type = type;
            classes = new ClassMemberListWrapper<TClass, StaticClassNestedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.InternalNode,
                () => new StaticClassNestedClassWithCodeAnalysis());
            abstractClasses = new ClassMemberListWrapper<TClass, StaticClassNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.InternalNode,
                () => new StaticClassNestedAbstractClassWithCodeAnalysis());
            sealedClasses = new ClassMemberListWrapper<TClass, StaticClassNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.InternalNode,
                () => new StaticClassNestedSealedClassWithCodeAnalysis());
            staticClasses = new ClassMemberListWrapper<TClass, StaticClassNestedStaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.InternalNode,
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
