using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal interface INodeFactory
    {
        ProjectNode CreateProjectNode(Project project, SolutionNode solution);

        DocumentNode CreateDocumentNode(Document document, ProjectNode project);

        NamespaceNode CreateNamespaceNode(string namespaceName);

        ClassNode CreateClassNode(ClassDeclarationSyntax declaration, ITypeContainer container);

        ClassDeclarationNode CreateClassDeclarationNode(ClassDeclarationSyntax declaration, ITypeContainer container);

        DelegateNode CreateDelegateNode(DelegateDeclarationSyntax declaration, ITypeContainer container);

        EnumNode CreateEnumNode(EnumDeclarationSyntax declaration, ITypeContainer container);

        InterfaceNode CreateInterfaceNode(InterfaceDeclarationSyntax declaration, ITypeContainer container);

        InterfaceDeclarationNode CreateInterfaceDeclarationNode(
            InterfaceDeclarationSyntax declaration,
            ITypeContainer container);

        StructNode CreateStructNode(StructDeclarationSyntax declaration, ITypeContainer container);

        StructDeclarationNode CreateStructDeclarationNode(StructDeclarationSyntax declaration, ITypeContainer container);

        ConstructorNode CreateConstructorNode(ConstructorDeclarationSyntax declaration, IMemberContainer container);

        ConversionOperatorNode CreateConversionOperatorNode(
            ConversionOperatorDeclarationSyntax declaration,
            IMemberContainer container);

        DestructorNode CreateDestructorNode(DestructorDeclarationSyntax declaration, ClassDeclarationNode container);

        EventNode CreateEventNode(EventFieldDeclarationSyntax declaration, IBasicMemberContainer container);

        EventPropertyNode CreateEventPropertyNode(EventDeclarationSyntax declaration, IMemberContainer container);

        FieldNode CreateFieldNode(FieldDeclarationSyntax declaration, IMemberContainer container);

        IndexerNode CreateIndexerNode(IndexerDeclarationSyntax declaration, IBasicMemberContainer container);

        MethodNode CreateMethodNode(MethodDeclarationSyntax declaration, IBasicMemberContainer container);

        OperatorOverloadNode CreateOperatorOverloadNode(OperatorDeclarationSyntax declaration, IMemberContainer container);

        PropertyNode CreatePropertyNode(PropertyDeclarationSyntax declaration, IBasicMemberContainer container);

        EnumMemberNode CreateEnumMemberNode(EnumMemberDeclarationSyntax declaration, EnumNode container);
    }
}
