using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Builder
{
    internal sealed class NamespaceContainer : IDisposable
    {
        private readonly SyntaxBuilder builder;

        public NamespaceContainer(NamespaceDeclarationSyntax declaration, SyntaxBuilder builder)
        {
            this.builder = builder;
            string namespaceName = BuildNamespaceName(declaration);
            NamespaceNode internalNamespace;
            if (!builder.NamespacesByName.TryGetValue(namespaceName, out internalNamespace))
            {
                internalNamespace = builder.NodeFactory.CreateNamespaceNode(namespaceName);
                builder.NamespacesByName.Add(namespaceName, internalNamespace);
            }

            internalNamespace.Declarations.Add(declaration);
            builder.NamespaceStack.Push(internalNamespace);
            builder.TypeContainer.Push(internalNamespace);
        }

        public void Dispose()
        {
            builder.NamespaceNameStack.Pop();
            builder.NamespaceStack.Pop();
            builder.TypeContainer.Pop();
        }

        private string BuildNamespaceName(NamespaceDeclarationSyntax declaration)
        {
            string namespaceName = declaration.Name.ToString();
            if (builder.NamespaceNameStack.Count != 0)
            {
                namespaceName = builder.NamespaceNameStack.Pop() + "." + namespaceName;
            }

            builder.NamespaceNameStack.Push(namespaceName);
            return namespaceName;
        }
    }
}
