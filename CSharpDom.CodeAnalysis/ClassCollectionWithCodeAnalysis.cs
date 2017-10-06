using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses.Editable;
using CSharpDom.CodeAnalysis.Partial;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ClassCollectionWithCodeAnalysis :
        EditableClassCollection<
            ClassWithCodeAnalysis,
            AbstractClassWithCodeAnalysis,
            SealedClassWithCodeAnalysis,
            StaticClassWithCodeAnalysis,
            PartialClassCollectionWithCodeAnalysis>,
        IClassCollectionWithCodeAnalysis
    {
        private readonly IMemberList members;
        private readonly ICollection<AbstractClassWithCodeAnalysis> abstractClasses;
        private readonly ICollection<ClassWithCodeAnalysis> classes;
        private readonly ICollection<SealedClassWithCodeAnalysis> sealedClasses;
        private readonly ICollection<StaticClassWithCodeAnalysis> staticClasses;
        private readonly PartialClassCollectionWithCodeAnalysis partialClasses;

        internal ClassCollectionWithCodeAnalysis(NamespaceWithCodeAnalysis @namespace)
        {
            members = @namespace.Members;
            abstractClasses = new NamespaceMemberListWrapper<AbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new AbstractClassWithCodeAnalysis(@namespace.Document),
                ClassDeclarationSyntaxExtensions.IsAbstractClass);
            classes = new NamespaceMemberListWrapper<ClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new ClassWithCodeAnalysis(@namespace.Document),
                ClassDeclarationSyntaxExtensions.IsClass);
            sealedClasses = new NamespaceMemberListWrapper<SealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new SealedClassWithCodeAnalysis(@namespace.Document),
                ClassDeclarationSyntaxExtensions.IsSealedClass);
            staticClasses = new NamespaceMemberListWrapper<StaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new StaticClassWithCodeAnalysis(@namespace.Document),
                ClassDeclarationSyntaxExtensions.IsStaticClass);
            partialClasses = PartialClassCollectionWithCodeAnalysis.Create(@namespace);
        }

        internal ClassCollectionWithCodeAnalysis(LoadedDocumentWithCodeAnalysis document)
        {
            members = document.Members;
            abstractClasses = new LoadedDocumentMemberListWrapper<AbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                document.Node,
                () => new AbstractClassWithCodeAnalysis(document.Document),
                ClassDeclarationSyntaxExtensions.IsAbstractClass);
            classes = new LoadedDocumentMemberListWrapper<ClassWithCodeAnalysis, ClassDeclarationSyntax>(
                document.Node,
                () => new ClassWithCodeAnalysis(document.Document),
                ClassDeclarationSyntaxExtensions.IsClass);
            sealedClasses = new LoadedDocumentMemberListWrapper<SealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                document.Node,
                () => new SealedClassWithCodeAnalysis(document.Document),
                ClassDeclarationSyntaxExtensions.IsSealedClass);
            staticClasses = new LoadedDocumentMemberListWrapper<StaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                document.Node,
                () => new StaticClassWithCodeAnalysis(document.Document),
                ClassDeclarationSyntaxExtensions.IsStaticClass);
            partialClasses = PartialClassCollectionWithCodeAnalysis.Create(document);
        }
        
        public override ICollection<AbstractClassWithCodeAnalysis> AbstractClasses
        {
            get { return abstractClasses; }
            set { members.CombineList(nameof(AbstractClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<ClassWithCodeAnalysis> Classes
        {
            get { return classes; }
            set { members.CombineList(nameof(Classes), value.Select(item => item.Syntax)); }
        }

        public override PartialClassCollectionWithCodeAnalysis PartialClasses
        {
            get { return partialClasses; }
            set { partialClasses.Replace(value); }
        }

        public override ICollection<SealedClassWithCodeAnalysis> SealedClasses
        {
            get { return sealedClasses; }
            set { members.CombineList(nameof(SealedClasses), value.Select(item => item.Syntax)); }
        }

        public override ICollection<StaticClassWithCodeAnalysis> StaticClasses
        {
            get { return staticClasses; }
            set { members.CombineList(nameof(StaticClasses), value.Select(item => item.Syntax)); }
        }
    }
}
