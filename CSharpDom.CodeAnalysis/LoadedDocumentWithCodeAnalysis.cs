using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class LoadedDocumentWithCodeAnalysis :
        EditableLoadedDocument<
            SolutionWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            DocumentWithCodeAnalysis,
            UsingDirectiveWithCodeAnalysis,
            AttributeGroupWithCodeAnalysis,
            NamespaceWithCodeAnalysis,
            ClassCollectionWithCodeAnalysis,
            DelegateWithCodeAnalysis,
            EnumWithCodeAnalysis,
            InterfaceWithCodeAnalysis,
            StructCollectionWithCodeAnalysis>,
        IHasSyntax<CompilationUnitSyntax>,
        IHasNode<CompilationUnitSyntax>
    {
        private readonly DocumentWithCodeAnalysis document;
        private readonly Node<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax> node;
        private readonly AttributeListWrapper<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax> attributes;
        private readonly FilteredAttributeList assemblyAttributes;
        private readonly ClassCollectionWithCodeAnalysis classes;
        private readonly LoadedDocumentMemberListWrapper<DelegateWithCodeAnalysis, DelegateDeclarationSyntax> delegates;
        private readonly LoadedDocumentMemberListWrapper<EnumWithCodeAnalysis, EnumDeclarationSyntax> enums;
        private readonly LoadedDocumentMemberListWrapper<InterfaceWithCodeAnalysis, InterfaceDeclarationSyntax> interfaces;
        private readonly FilteredAttributeList moduleAttributes;
        private readonly LoadedDocumentMemberListWrapper<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax> namespaces;
        private readonly StructCollectionWithCodeAnalysis structs;
        private readonly SyntaxListWrapper<
            LoadedDocumentWithCodeAnalysis,
            CompilationUnitSyntax,
            UsingDirectiveWithCodeAnalysis,
            UsingDirectiveSyntax> usingDirectives;
        private readonly MemberList<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax> members;

        internal LoadedDocumentWithCodeAnalysis(DocumentWithCodeAnalysis document, CompilationUnitSyntax syntax)
        {
            this.document = document;
            node = new Node<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax>(this, syntax);
            attributes = new AttributeListWrapper<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax>(
                node,
                parentSyntax => parentSyntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax));
            assemblyAttributes = new FilteredAttributeList(attributes, attribute => attribute.Syntax.Target.Identifier.Text == "assembly");
            classes = new ClassCollectionWithCodeAnalysis(this);
            delegates = new LoadedDocumentMemberListWrapper<DelegateWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                () => new DelegateWithCodeAnalysis(document));
            enums = new LoadedDocumentMemberListWrapper<EnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                () => new EnumWithCodeAnalysis(document));
            interfaces = new LoadedDocumentMemberListWrapper<InterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                () => new InterfaceWithCodeAnalysis(document));
            moduleAttributes = new FilteredAttributeList(attributes, attribute => attribute.Syntax.Target.Identifier.Text == "module");
            namespaces = new LoadedDocumentMemberListWrapper<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax>(
                node,
                () => new NamespaceWithCodeAnalysis(document));
            structs = new StructCollectionWithCodeAnalysis(this);
            usingDirectives = new SyntaxListWrapper<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax, UsingDirectiveWithCodeAnalysis, UsingDirectiveSyntax>(
                node,
                currentSyntax => currentSyntax.Usings,
                (parentSyntax, childSyntax) => parentSyntax.WithUsings(childSyntax),
                () => new UsingDirectiveWithCodeAnalysis());
            members = new MemberList<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax>(
                node,
                (parentSyntax, childSyntax) => parentSyntax.WithMembers(childSyntax))
            {
                { nameof(classes.Classes), () => classes.Classes.Select(item => item.Syntax) },
                { nameof(classes.AbstractClasses), () => classes.AbstractClasses.Select(item => item.Syntax) },
                { nameof(classes.SealedClasses), () => classes.SealedClasses.Select(item => item.Syntax) },
                { nameof(classes.StaticClasses), () => classes.StaticClasses.Select(item => item.Syntax) },
                { nameof(Delegates), () => delegates.Select(item => item.Syntax) },
                { nameof(Enums), () => enums.Select(item => item.Syntax) },
                { nameof(Interfaces), () => interfaces.Select(item => item.Syntax) },
                { nameof(Namespaces), () => namespaces.Select(item => item.Syntax) },
                { nameof(structs.Structs), () => structs.Structs.Select(item => item.Syntax) }
            };
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> AssemblyAttributes
        {
            get { return assemblyAttributes; }
            set { Syntax = Syntax.WithAttributeLists(SyntaxFactory.List(value.Concat(moduleAttributes).Select(item => item.Syntax))); }
        }

        public override ClassCollectionWithCodeAnalysis Classes
        {
            get { return classes; }
            set
            {
                members.CombineList(
                    new MemberListSyntax(nameof(classes.Classes), value.Classes.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.AbstractClasses), value.AbstractClasses.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.SealedClasses), value.SealedClasses.Select(item => item.Syntax)),
                    new MemberListSyntax(nameof(classes.StaticClasses), value.StaticClasses.Select(item => item.Syntax)));
            }
        }

        public override ICollection<DelegateWithCodeAnalysis> Delegates
        {
            get { return delegates; }
            set { members.CombineList(new MemberListSyntax(nameof(Delegates), value.Select(item => item.Syntax))); }
        }

        public override DocumentWithCodeAnalysis Document
        {
            get { return document; }
            set { throw new NotSupportedException(); }
        }

        public override ICollection<EnumWithCodeAnalysis> Enums
        {
            get { return enums; }
            set { members.CombineList(new MemberListSyntax(nameof(Enums), value.Select(item => item.Syntax))); }
        }

        public override ICollection<InterfaceWithCodeAnalysis> Interfaces
        {
            get { return interfaces; }
            set { members.CombineList(nameof(Interfaces), value.Select(item => item.Syntax)); }
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> ModuleAttributes
        {
            get { return moduleAttributes; }
            set { Syntax = Syntax.WithAttributeLists(SyntaxFactory.List(assemblyAttributes.Concat(value).Select(item => item.Syntax))); }
        }

        public override ICollection<NamespaceWithCodeAnalysis> Namespaces
        {
            get { return namespaces; }
            set { members.CombineList(new MemberListSyntax(nameof(Namespaces), value.Select(item => item.Syntax))); }
        }

        public override ProjectWithCodeAnalysis Project
        {
            get { return document.Project; }
            set { throw new NotSupportedException(); }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return document.Solution; }
            set { throw new NotSupportedException(); }
        }

        public override StructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(new MemberListSyntax(nameof(structs.Structs), value.Structs.Select(item => item.Syntax))); }
        }

        public CompilationUnitSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override ICollection<UsingDirectiveWithCodeAnalysis> UsingDirectives
        {
            get { return usingDirectives; }
            set { usingDirectives.ReplaceList(value); }
        }

        internal IMemberList Members
        {
            get { return members; }
        }

        internal Node<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax> Node
        {
            get { return node; }
        }

        INode<CompilationUnitSyntax> IHasNode<CompilationUnitSyntax>.Node
        {
            get { return node; }
        }
    }
}
