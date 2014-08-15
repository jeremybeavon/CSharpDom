using System;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Builder
{
    internal sealed class ClassContainer : IDisposable
    {
        private SyntaxBuilder builder;

        public ClassContainer(ClassDeclarationSyntax declaration, SyntaxBuilder builder)
        {
            this.builder = builder;
            ITypeContainer typeContainer = builder.TypeContainer.Peek();
            ITypeContainer declarationTypeContainer = builder.DeclarationTypeContainer.Peek();
            ClassNode classNode = builder.NodeFactory.CreateClassNode(declaration, typeContainer);
            string nameWithGenericParameterCount = classNode.NameWithGenericParameterCount;
            ClassNode existingClass = typeContainer.Classes.FirstOrDefault(
                @class => @class.NameWithGenericParameterCount == nameWithGenericParameterCount);
            if (existingClass == null)
            {
                typeContainer.Classes.Add(classNode);
                if (typeContainer != declarationTypeContainer)
                {
                    declarationTypeContainer.Classes.Add(classNode);
                }
            }
            else
            {
                classNode = existingClass;
            }

            ClassDeclarationNode classDeclarationNode =
                builder.NodeFactory.CreateClassDeclarationNode(declaration, declarationTypeContainer);
            classNode.Declarations.Add(classDeclarationNode);
            classDeclarationNode.ClassNode = classNode;
            builder.TypeContainer.Push(classDeclarationNode);
            builder.DeclarationTypeContainer.Push(classDeclarationNode);
            builder.BasicMemberContainer.Push(classDeclarationNode);
            builder.MemberContainer.Push(classDeclarationNode);
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
