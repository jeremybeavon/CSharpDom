using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NamespaceWithCodeAnalysis :
        EditableNamespace<
            UsingDirectiveWithCodeAnalysis,
            NamespaceWithCodeAnalysis,
            ClassCollectionWithCodeAnalysis,
            DelegateWithCodeAnalysis,
            EnumWithCodeAnalysis,
            InterfaceWithCodeAnalysis,
            StructCollectionWithCodeAnalysis>,
        IHasSyntax<NamespaceDeclarationSyntax>,
        IHasNode<NamespaceDeclarationSyntax>,
        IHasDocument<DocumentWithCodeAnalysis>//,
                                             //IVisitable<IReflectionVisitor>
    {
        private readonly DocumentWithCodeAnalysis document;
        private readonly Node<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax> node;
        private readonly ClassCollectionWithCodeAnalysis classes;
        private readonly NamespaceMemberListWrapper<DelegateWithCodeAnalysis, DelegateDeclarationSyntax> delegates;
        private readonly NamespaceMemberListWrapper<EnumWithCodeAnalysis, EnumDeclarationSyntax> enums;
        private readonly NamespaceMemberListWrapper<InterfaceWithCodeAnalysis, InterfaceDeclarationSyntax> interfaces;
        private readonly NamespaceMemberListWrapper<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax> namespaces;
        private readonly StructCollectionWithCodeAnalysis structs;
        private readonly SyntaxListWrapper<
            NamespaceWithCodeAnalysis,
            NamespaceDeclarationSyntax,
            UsingDirectiveWithCodeAnalysis,
            UsingDirectiveSyntax> usingDirectives;
        private readonly MemberList<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax> members;

        internal NamespaceWithCodeAnalysis(DocumentWithCodeAnalysis document)
        {
            node = new Node<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax>(this);
            this.document = document;
            classes = new ClassCollectionWithCodeAnalysis(this);
            delegates = new NamespaceMemberListWrapper<DelegateWithCodeAnalysis, DelegateDeclarationSyntax>(
                node,
                () => new DelegateWithCodeAnalysis(document));
            enums = new NamespaceMemberListWrapper<EnumWithCodeAnalysis, EnumDeclarationSyntax>(
                node,
                () => new EnumWithCodeAnalysis(document));
            interfaces = new NamespaceMemberListWrapper<InterfaceWithCodeAnalysis, InterfaceDeclarationSyntax>(
                node,
                () => new InterfaceWithCodeAnalysis(document));
            namespaces = new NamespaceMemberListWrapper<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax>(
                node,
                () => new NamespaceWithCodeAnalysis(document));
            structs = new StructCollectionWithCodeAnalysis(this);
            usingDirectives = new SyntaxListWrapper<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax, UsingDirectiveWithCodeAnalysis, UsingDirectiveSyntax>(
                node,
                syntax => syntax.Usings,
                (parentSyntax, childSyntax) => parentSyntax.WithUsings(childSyntax),
                () => new UsingDirectiveWithCodeAnalysis());
            members = new MemberList<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax>(
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
                { nameof(structs.Structs), () => structs.Structs.Select(item => item.Syntax) },
                { nameof(structs.PartialStructs), () => structs.PartialStructs.Select(item => item.Syntax) }
            };
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

        public override string Name
        {
            get { return Syntax.Name.ToString(); }
            set { Syntax = Syntax.WithName(SyntaxFactory.ParseName(value)); }
        }

        public override ICollection<NamespaceWithCodeAnalysis> Namespaces
        {
            get { return namespaces; }
            set { members.CombineList(new MemberListSyntax(nameof(Namespaces), value.Select(item => item.Syntax))); }
        }

        public override StructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
            set { members.CombineList(new MemberListSyntax(nameof(structs.Structs), value.Structs.Select(item => item.Syntax))); }
        }

        public NamespaceDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override ICollection<UsingDirectiveWithCodeAnalysis> UsingDirectives
        {
            get { return usingDirectives; }
            set { usingDirectives.ReplaceList(value); }
        }

        INode<NamespaceDeclarationSyntax> IHasNode<NamespaceDeclarationSyntax>.Node
        {
            get { return node; }
        }

        internal IMemberList Members
        {
            get { return members; }
        }

        internal Node<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax> Node
        {
            get { return node; }
        }

        public DocumentWithCodeAnalysis Document => document;
    }
}
