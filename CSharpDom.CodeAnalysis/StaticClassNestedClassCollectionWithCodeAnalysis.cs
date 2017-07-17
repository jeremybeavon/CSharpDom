using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class StaticClassNestedClassCollectionWithCodeAnalysis :
        EditableStaticClassNestedClassCollection<
            StaticClassNestedClassWithCodeAnalysis,
            StaticClassNestedAbstractClassWithCodeAnalysis,
            StaticClassNestedSealedClassWithCodeAnalysis,
            StaticClassNestedStaticClassWithCodeAnalysis,
            StaticClassNestedPartialClassCollectionWithCodeAnalysis>
    {
        private readonly StaticClassWithCodeAnalysis type;
        private readonly StaticClassMemberListWrapper<
            StaticClassNestedClassWithCodeAnalysis,
            ClassDeclarationSyntax> classes;
        private readonly StaticClassMemberListWrapper<
            StaticClassNestedAbstractClassWithCodeAnalysis,
            ClassDeclarationSyntax> abstractClasses;
        private readonly StaticClassMemberListWrapper<
            StaticClassNestedSealedClassWithCodeAnalysis,
            ClassDeclarationSyntax> sealedClasses;
        private readonly StaticClassMemberListWrapper<
            StaticClassNestedStaticClassWithCodeAnalysis,
            ClassDeclarationSyntax> staticClasses;
        private readonly StaticClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        internal StaticClassNestedClassCollectionWithCodeAnalysis(
            StaticClassWithCodeAnalysis type)
        {
            this.type = type;
            classes = new StaticClassMemberListWrapper<StaticClassNestedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedClassWithCodeAnalysis());
            abstractClasses = new StaticClassMemberListWrapper<StaticClassNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedAbstractClassWithCodeAnalysis());
            sealedClasses = new StaticClassMemberListWrapper<StaticClassNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticClassNestedSealedClassWithCodeAnalysis());
            staticClasses = new StaticClassMemberListWrapper<StaticClassNestedStaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
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
