using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class TypeResolver
    {
        private readonly SemanticModel semanticModel;

        public TypeResolver(SemanticModel semanticModel)
        {
            this.semanticModel = semanticModel;
        }

        public Type GetType(TypeSyntax node)
        {
            TypeInfo type = semanticModel.GetTypeInfo(node);
            return null;
        }

        /*private class Test : IHasName, ICanBeGeneric, IHasNamespace<INamespaceWithReflection>, IHasProject<IProjectWithReflection>,
            INamespaceWithReflection, IProjectWithReflection
        {
            //private readonly TypeInfo type;



            public string Name
            {
                get { throw new NotImplementedException(); }
            }

            public bool IsGeneric
            {
                get { throw new NotImplementedException(); }
            }

            public int GenericParameterCount
            {
                get { throw new NotImplementedException(); }
            }

            public INamespaceWithReflection Namespace
            {
                get { throw new NotImplementedException(); }
            }

            public IProjectWithReflection Project
            {
                get { throw new NotImplementedException(); }
            }

            public void Accept(IReflectionVisitor visitor)
            {
                throw new NotImplementedException();
            }


            public IEnumerable<NamespaceDeclarationSyntax> Declarations
            {
                get { throw new NotImplementedException(); }
            }

            public IReadOnlyCollection<IClassWithReflection> Classes
            {
                get { throw new NotImplementedException(); }
            }

            public IReadOnlyCollection<IDelegateWithReflection> Delegates
            {
                get { throw new NotImplementedException(); }
            }

            public IReadOnlyCollection<IEnumWithReflection> Enums
            {
                get { throw new NotImplementedException(); }
            }

            public IReadOnlyCollection<IInterfaceWithReflection> Interfaces
            {
                get { throw new NotImplementedException(); }
            }

            public IReadOnlyCollection<IStructWithReflection> Structs
            {
                get { throw new NotImplementedException(); }
            }

            public WithSyntax.INamespaceSyntax Syntax
            {
                get { throw new NotImplementedException(); }
            }

            public WithSymbols.INamespaceWithSymbols Symbols
            {
                get { throw new NotImplementedException(); }
            }

            public Task AcceptAsync(IReflectionVisitor visitor)
            {
                throw new NotImplementedException();
            }

            Project IProject<IDocumentWithReflection>.Project
            {
                get { throw new NotImplementedException(); }
            }

            public IReadOnlyCollection<IDocumentWithReflection> Documents
            {
                get { throw new NotImplementedException(); }
            }

            public System.Reflection.Assembly Assembly
            {
                get { throw new NotImplementedException(); }
            }

            public ISolutionWithReflection Solution
            {
                get { throw new NotImplementedException(); }
            }

            public IAsyncEnumerable<INamespaceWithReflection, IDocumentWithReflection> Namespaces
            {
                get { throw new NotImplementedException(); }
            }

            IAsyncEnumerable<IClassWithReflection, IDocumentWithReflection> IReflectionContainer.Classes
            {
                get { throw new NotImplementedException(); }
            }

            IAsyncEnumerable<IDelegateWithReflection, IDocumentWithReflection> IReflectionContainer.Delegates
            {
                get { throw new NotImplementedException(); }
            }

            IAsyncEnumerable<IEnumWithReflection, IDocumentWithReflection> IReflectionContainer.Enums
            {
                get { throw new NotImplementedException(); }
            }

            IAsyncEnumerable<IInterfaceWithReflection, IDocumentWithReflection> IReflectionContainer.Interfaces
            {
                get { throw new NotImplementedException(); }
            }

            IAsyncEnumerable<IStructWithReflection, IDocumentWithReflection> IReflectionContainer.Structs
            {
                get { throw new NotImplementedException(); }
            }

            WithSyntax.IProjectSyntax IHasSyntax<WithSyntax.IProjectSyntax>.Syntax
            {
                get { throw new NotImplementedException(); }
            }

            WithSymbols.IProjectWithSymbols IHasSymbols<WithSymbols.IProjectWithSymbols>.Symbols
            {
                get { throw new NotImplementedException(); }
            }
        }*/
    }
}
