using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Builder
{
    internal sealed class StructContainer : IDisposable
    {
        private SyntaxBuilder builder;

        public StructContainer(StructDeclarationSyntax declaration, SyntaxBuilder builder)
        {
            this.builder = builder;
            ITypeContainer typeContainer = builder.TypeContainer.Peek();
            ITypeContainer declarationTypeContainer = builder.DeclarationTypeContainer.Peek();
            StructNode structNode = builder.NodeFactory.CreateStructNode(declaration, typeContainer);
            string nameWithGenericParameterCount = structNode.NameWithGenericParameterCount;
            StructNode existingStruct = typeContainer.Structs.FirstOrDefault(
                @struct => @struct.NameWithGenericParameterCount == nameWithGenericParameterCount);
            if (existingStruct == null)
            {
                typeContainer.Structs.Add(structNode);
                if (typeContainer != declarationTypeContainer)
                {
                    declarationTypeContainer.Structs.Add(structNode);
                }
            }
            else
            {
                structNode = existingStruct;
            }

            StructDeclarationNode structDeclarationNode =
                builder.NodeFactory.CreateStructDeclarationNode(declaration, declarationTypeContainer);
            structNode.Declarations.Add(structDeclarationNode);
            structDeclarationNode.StructNode = structNode;
            builder.TypeContainer.Push(structDeclarationNode);
            builder.DeclarationTypeContainer.Push(structDeclarationNode);
            builder.BasicMemberContainer.Push(structDeclarationNode);
            builder.MemberContainer.Push(structDeclarationNode);
        }

        public void Dispose()
        {
            builder.TypeContainer.Pop();
            builder.DeclarationTypeContainer.Pop();
            builder.BasicMemberContainer.Pop();
            builder.MemberContainer.Pop();
        }
    }
}
