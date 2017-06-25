using System;
using System.Collections.Generic;
using CSharpDom.Editable;
using CSharpDom.NotSupported;
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
            PartialClassCollectionNotSupported>
    {
        private readonly IMemberList members;
        private readonly ICollection<AbstractClassWithCodeAnalysis> abstractClasses;
        private readonly ICollection<ClassWithCodeAnalysis> classes;
        private readonly ICollection<SealedClassWithCodeAnalysis> sealedClasses;
        private readonly ICollection<StaticClassWithCodeAnalysis> staticClasses;

        internal ClassCollectionWithCodeAnalysis(NamespaceWithCodeAnalysis @namespace)
        {
            members = @namespace.Members;
            abstractClasses = new NamespaceMemberListWrapper<AbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new AbstractClassWithCodeAnalysis(null));
            classes = new NamespaceMemberListWrapper<ClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new ClassWithCodeAnalysis(null));
            sealedClasses = new NamespaceMemberListWrapper<SealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new SealedClassWithCodeAnalysis());
            staticClasses = new NamespaceMemberListWrapper<StaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new StaticClassWithCodeAnalysis());
        }

        internal ClassCollectionWithCodeAnalysis(LoadedDocumentWithCodeAnalysis document)
        {
            members = document.Members;
            abstractClasses = new LoadedDocumentMemberListWrapper<AbstractClassWithCodeAnalysis, ClassDeclarationSyntax>(
                document.Node,
                () => new AbstractClassWithCodeAnalysis(document.Document));
            classes = new LoadedDocumentMemberListWrapper<ClassWithCodeAnalysis, ClassDeclarationSyntax>(
                document.Node,
                () => new ClassWithCodeAnalysis(document.Document));
            sealedClasses = new LoadedDocumentMemberListWrapper<SealedClassWithCodeAnalysis, ClassDeclarationSyntax>(
                document.Node,
                () => new SealedClassWithCodeAnalysis());
            staticClasses = new LoadedDocumentMemberListWrapper<StaticClassWithCodeAnalysis, ClassDeclarationSyntax>(
                document.Node,
                () => new StaticClassWithCodeAnalysis());
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

        public override PartialClassCollectionNotSupported PartialClasses
        {
            get
            {
                return new PartialClassCollectionNotSupported();
            }

            set
            {
                throw new NotSupportedException();
            }
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
