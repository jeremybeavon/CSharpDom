using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Partial
{
    public sealed class PartialClassCollectionWithCodeAnalysis :
        GenericPartialClassCollectionWithCodeAnalysis<
            PartialClassWithCodeAnalysis,
            AbstractPartialClassWithCodeAnalysis,
            SealedPartialClassWithCodeAnalysis,
            StaticPartialClassWithCodeAnalysis>
    {
        private PartialClassCollectionWithCodeAnalysis(
            IMemberList members,
            ICollection<AbstractPartialClassWithCodeAnalysis> abstractClasses,
            ICollection<PartialClassWithCodeAnalysis> classes,
            ICollection<SealedPartialClassWithCodeAnalysis> sealedClasses,
            ICollection<StaticPartialClassWithCodeAnalysis> staticClasses)
            : base(members, abstractClasses, classes, sealedClasses, staticClasses)
        {
        }

        internal static PartialClassCollectionWithCodeAnalysis Create(NamespaceWithCodeAnalysis @namespace)
        {
            var members = @namespace.Members;
            var abstractClasses = new NamespaceMemberListWrapper<AbstractPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new AbstractPartialClassWithCodeAnalysis(@namespace.Document),
                ClassDeclarationSyntaxExtensions.IsAbstractPartialClass);
            var classes = new NamespaceMemberListWrapper<PartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new PartialClassWithCodeAnalysis(@namespace.Document),
                ClassDeclarationSyntaxExtensions.IsPartialClass);
            var sealedClasses = new NamespaceMemberListWrapper<SealedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new SealedPartialClassWithCodeAnalysis(@namespace.Document),
                ClassDeclarationSyntaxExtensions.IsSealedPartialClass);
            var staticClasses = new NamespaceMemberListWrapper<StaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                @namespace.Node,
                () => new StaticPartialClassWithCodeAnalysis(@namespace.Document),
                ClassDeclarationSyntaxExtensions.IsStaticPartialClass);
            return new PartialClassCollectionWithCodeAnalysis(members, abstractClasses, classes, sealedClasses, staticClasses);
        }

        internal static PartialClassCollectionWithCodeAnalysis Create(LoadedDocumentWithCodeAnalysis document)
        {
            var members = document.Members;
            var abstractClasses = new LoadedDocumentMemberListWrapper<AbstractPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                document.Node,
                () => new AbstractPartialClassWithCodeAnalysis(document.Document),
                ClassDeclarationSyntaxExtensions.IsAbstractPartialClass);
            var classes = new LoadedDocumentMemberListWrapper<PartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                document.Node,
                () => new PartialClassWithCodeAnalysis(document.Document),
                ClassDeclarationSyntaxExtensions.IsPartialClass);
            var sealedClasses = new LoadedDocumentMemberListWrapper<SealedPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                document.Node,
                () => new SealedPartialClassWithCodeAnalysis(document.Document),
                ClassDeclarationSyntaxExtensions.IsSealedPartialClass);
            var staticClasses = new LoadedDocumentMemberListWrapper<StaticPartialClassWithCodeAnalysis, ClassDeclarationSyntax>(
                document.Node,
                () => new StaticPartialClassWithCodeAnalysis(document.Document),
                ClassDeclarationSyntaxExtensions.IsStaticPartialClass);
            return new PartialClassCollectionWithCodeAnalysis(members, abstractClasses, classes, sealedClasses, staticClasses);
        }
    }
}
