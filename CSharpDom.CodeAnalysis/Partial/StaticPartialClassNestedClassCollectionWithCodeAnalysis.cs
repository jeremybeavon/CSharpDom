using CSharpDom.Editable;
using CSharpDom.CodeAnalysis.Partial;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class StaticPartialClassNestedClassCollectionWithCodeAnalysis :
        EditableStaticClassNestedClassCollection<
            StaticPartialClassNestedClassWithCodeAnalysis,
            StaticPartialClassNestedAbstractClassWithCodeAnalysis,
            StaticPartialClassNestedSealedClassWithCodeAnalysis,
            StaticPartialClassNestedStaticClassWithCodeAnalysis,
            StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis>
    {
        private readonly StaticPartialClassWithCodeAnalysis type;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassNestedClassWithCodeAnalysis,
            ClassDeclarationSyntax> classes;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassNestedAbstractClassWithCodeAnalysis,
            ClassDeclarationSyntax> abstractClasses;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassNestedSealedClassWithCodeAnalysis,
            ClassDeclarationSyntax> sealedClasses;
        private readonly StaticPartialClassMemberListWrapper<
            StaticPartialClassNestedStaticClassWithCodeAnalysis,
            ClassDeclarationSyntax> staticClasses;
        private readonly StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis partialClasses;

        internal StaticPartialClassNestedClassCollectionWithCodeAnalysis(
            StaticPartialClassWithCodeAnalysis type)
        {
            this.type = type;
            classes = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticPartialClassNestedClassWithCodeAnalysis());
            abstractClasses = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedAbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticPartialClassNestedAbstractClassWithCodeAnalysis());
            sealedClasses = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedSealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticPartialClassNestedSealedClassWithCodeAnalysis());
            staticClasses = new StaticPartialClassMemberListWrapper<StaticPartialClassNestedStaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                type.Node,
                () => new StaticPartialClassNestedStaticClassWithCodeAnalysis());
            partialClasses = StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis.Create(type);
        }

        public override ICollection<StaticPartialClassNestedAbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { type.Members.CombineList(nameof(AbstractClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticPartialClassNestedClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { type.Members.CombineList(nameof(Classes), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticPartialClassNestedSealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { type.Members.CombineList(nameof(SealedClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticPartialClassNestedStaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { type.Members.CombineList(nameof(StaticClasses), value.Select(item => item.Syntax)); }
        }

        public override StaticPartialClassNestedPartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }
    }
}
