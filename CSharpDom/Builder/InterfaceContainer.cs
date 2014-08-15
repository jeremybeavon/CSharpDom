using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Builder
{
    internal sealed class InterfaceContainer : IDisposable
    {
        private readonly SyntaxBuilder builder;

        public InterfaceContainer(InterfaceDeclarationSyntax declaration, SyntaxBuilder builder)
        {
            this.builder = builder;
            ITypeContainer typeContainer = builder.TypeContainer.Peek();
            ITypeContainer declarationTypeContainer = builder.DeclarationTypeContainer.Peek();
            InterfaceNode interfaceNode = builder.NodeFactory.CreateInterfaceNode(declaration, typeContainer);
            string nameWithGenericParameterCount = interfaceNode.NameWithGenericParameterCount;
            InterfaceNode existingInterface = typeContainer.Interfaces.FirstOrDefault(
                @interface => @interface.NameWithGenericParameterCount == nameWithGenericParameterCount);
            if (existingInterface == null)
            {
                typeContainer.Interfaces.Add(interfaceNode);
                if (typeContainer != declarationTypeContainer)
                {
                    declarationTypeContainer.Interfaces.Add(interfaceNode);
                }
            }
            else
            {
                interfaceNode = existingInterface;
            }

            InterfaceDeclarationNode interfaceDeclarationNode =
                builder.NodeFactory.CreateInterfaceDeclarationNode(declaration, declarationTypeContainer);
            interfaceNode.Declarations.Add(interfaceDeclarationNode);
            interfaceDeclarationNode.InterfaceNode = interfaceNode;
            builder.BasicMemberContainer.Push(interfaceDeclarationNode);
        }

        public void Dispose()
        {
            builder.BasicMemberContainer.Pop();
        }
    }
}
