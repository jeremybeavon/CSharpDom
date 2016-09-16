using CSharpDom.Editable;
using CSharpDom.NotSupported;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NamespaceWithCodeAnalysis :
        EditableNamespace<
            UsingDirectiveNotSupported,
            NamespaceWithCodeAnalysis,
            ClassCollectionWithCodeAnalysis,
            DelegateWithCodeAnalysis,
            EnumWithCodeAnalysis,
            InterfaceCollectionWithCodeAnalysis,
            StructCollectionWithCodeAnalysis>,
        IHasSyntax<NamespaceDeclarationSyntax>,
        IHasNode<NamespaceDeclarationSyntax>//,
                                             //IVisitable<IReflectionVisitor>
    {
        private readonly Node<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax> node;

        public override ClassCollectionWithCodeAnalysis Classes
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override ICollection<DelegateWithCodeAnalysis> Delegates
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override ICollection<EnumWithCodeAnalysis> Enums
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override InterfaceCollectionWithCodeAnalysis Interfaces
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override ICollection<NamespaceWithCodeAnalysis> Namespaces
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override StructCollectionWithCodeAnalysis Structs
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public NamespaceDeclarationSyntax Syntax
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override ICollection<UsingDirectiveNotSupported> UsingDirectives
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        INode<NamespaceDeclarationSyntax> IHasNode<NamespaceDeclarationSyntax>.Node
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        internal Node<NamespaceWithCodeAnalysis, NamespaceDeclarationSyntax> Node
        {
            get { return node; }
        }
    }
}
