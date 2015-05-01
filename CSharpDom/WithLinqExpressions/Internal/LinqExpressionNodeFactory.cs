using System;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed class LinqExpressionNodeFactory : INodeFactory
    {
        private readonly SemanticModel semanticModel;
        private readonly IAssemblyLoader assemblyLoader;

        public LinqExpressionNodeFactory(SemanticModel semanticModel)
        {
            this.semanticModel = semanticModel;
        }

        public LinqExpressionNodeFactory(IAssemblyLoader assemblyLoader)
        {
            this.assemblyLoader = assemblyLoader;
        }

        public ClassDeclarationNode CreateClassDeclarationNode(
            ClassDeclarationSyntax declaration,
            ITypeContainer container)
        {
            return new ClassDeclarationNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public ClassNode CreateClassNode(ClassDeclarationSyntax declaration, ITypeContainer container)
        {
            return new ClassNodeWithLinqExpressions(declaration, container);
        }

        public ConstructorNode CreateConstructorNode(ConstructorDeclarationSyntax declaration, IMemberContainer container)
        {
            return new ConstructorNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public ConversionOperatorNode CreateConversionOperatorNode(
            ConversionOperatorDeclarationSyntax declaration,
            IMemberContainer container)
        {
            return new ConversionOperatorNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public DelegateNode CreateDelegateNode(DelegateDeclarationSyntax declaration, ITypeContainer container)
        {
            return new DelegateNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public DestructorNode CreateDestructorNode(DestructorDeclarationSyntax declaration, ClassDeclarationNode container)
        {
            return new DestructorNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public DocumentNode CreateDocumentNode(Document document, ProjectNode project)
        {
            return new DocumentNodeWithLinqExpressions(document, project);
        }

        public EnumMemberNode CreateEnumMemberNode(EnumMemberDeclarationSyntax declaration, EnumNode container)
        {
            return new EnumMemberNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public EnumNode CreateEnumNode(EnumDeclarationSyntax declaration, ITypeContainer container)
        {
            return new EnumNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public EventNode CreateEventNode(EventFieldDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new EventNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public EventPropertyNode CreateEventPropertyNode(EventDeclarationSyntax declaration, IMemberContainer container)
        {
            return new EventPropertyNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public FieldNode CreateFieldNode(FieldDeclarationSyntax declaration, IMemberContainer container)
        {
            return new FieldNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public IndexerNode CreateIndexerNode(IndexerDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new IndexerNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public InterfaceDeclarationNode CreateInterfaceDeclarationNode(
            InterfaceDeclarationSyntax declaration,
            ITypeContainer container)
        {
            return new InterfaceDeclarationNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public InterfaceNode CreateInterfaceNode(InterfaceDeclarationSyntax declaration, ITypeContainer container)
        {
            return new InterfaceNodeWithLinqExpressions(declaration, container);
        }

        public MethodNode CreateMethodNode(MethodDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new MethodNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public NamespaceNode CreateNamespaceNode(string namespaceName)
        {
            return new NamespaceNodeWithLinqExpressions(namespaceName);
        }

        public OperatorOverloadNode CreateOperatorOverloadNode(
            OperatorDeclarationSyntax declaration,
            IMemberContainer container)
        {
            return new OperatorOverloadNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public ProjectNode CreateProjectNode(Project project, SolutionNode solution)
        {
            return new ProjectNodeWithLinqExpressions(project, solution, assemblyLoader);
        }

        public PropertyNode CreatePropertyNode(PropertyDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new PropertyNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public StructDeclarationNode CreateStructDeclarationNode(
            StructDeclarationSyntax declaration,
            ITypeContainer container)
        {
            return new StructDeclarationNodeWithLinqExpressions(declaration, container, semanticModel);
        }

        public StructNode CreateStructNode(StructDeclarationSyntax declaration, ITypeContainer container)
        {
            return new StructNodeWithLinqExpressions(declaration, container);
        }
    }
}
