using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class LoadedDocumentWithCodeAnalysis :
        EditableLoadedDocument<
            SolutionWithCodeAnalysis,
            ProjectWithCodeAnalysis,
            DocumentWithCodeAnalysis,
            IUsingDirective,
            AttributeGroupWithCodeAnalysis,
            NamespaceWithCodeAnalysis,
            ClassCollectionWithCodeAnalysis,
            DelegateWithCodeAnalysis,
            EnumWithCodeAnalysis,
            InterfaceCollectionWithCodeAnalysis,
            StructCollectionWithCodeAnalysis>,
        IHasSyntax<CompilationUnitSyntax>,
        IHasNode<CompilationUnitSyntax>
    {
        private readonly Node<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax> node;

        internal LoadedDocumentWithCodeAnalysis(CompilationUnitSyntax syntax)
        {
            node = new Node<LoadedDocumentWithCodeAnalysis, CompilationUnitSyntax>(this, syntax);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> AssemblyAttributes
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

        public override DocumentWithCodeAnalysis Document
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

        public override ICollection<AttributeGroupWithCodeAnalysis> ModuleAttributes
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

        public override ProjectWithCodeAnalysis Project
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

        public override SolutionWithCodeAnalysis Solution
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

        public CompilationUnitSyntax Syntax
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

        public override ICollection<IUsingDirective> UsingDirectives
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

        INode<CompilationUnitSyntax> IHasNode<CompilationUnitSyntax>.Node
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
