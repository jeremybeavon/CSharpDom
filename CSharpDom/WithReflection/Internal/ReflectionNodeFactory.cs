using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal sealed class ReflectionNodeFactory : INodeFactory
    {
        private readonly SemanticModel semanticModel;
        private readonly IAssemblyLoader assemblyLoader;

        public ReflectionNodeFactory(SemanticModel semanticModel)
        {
            this.semanticModel = semanticModel;
        }

        public ReflectionNodeFactory(IAssemblyLoader assemblyLoader)
        {
            this.assemblyLoader = assemblyLoader;
        }

        public ClassDeclarationNode CreateClassDeclarationNode(
            ClassDeclarationSyntax declaration,
            ITypeContainer container)
        {
            return new ClassDeclarationNodeWithReflection(declaration, container, semanticModel);
        }

        public ClassNode CreateClassNode(ClassDeclarationSyntax declaration, ITypeContainer container)
        {
            return new ClassNodeWithReflection(declaration, container);
        }

        public ConstructorNode CreateConstructorNode(ConstructorDeclarationSyntax declaration, IMemberContainer container)
        {
            return new ConstructorNodeWithReflection(declaration, container, semanticModel);
        }

        public ConversionOperatorNode CreateConversionOperatorNode(
            ConversionOperatorDeclarationSyntax declaration,
            IMemberContainer container)
        {
            return new ConversionOperatorNodeWithReflection(declaration, container, semanticModel);
        }

        public DelegateNode CreateDelegateNode(DelegateDeclarationSyntax declaration, ITypeContainer container)
        {
            return new DelegateNodeWithReflection(declaration, container, semanticModel);
        }

        public DestructorNode CreateDestructorNode(DestructorDeclarationSyntax declaration, ClassDeclarationNode container)
        {
            return new DestructorNodeWithReflection(declaration, container, semanticModel);
        }

        public DocumentNode CreateDocumentNode(Document document, ProjectNode project)
        {
            return new DocumentNodeWithReflection(document, project);
        }

        public EnumMemberNode CreateEnumMemberNode(EnumMemberDeclarationSyntax declaration, EnumNode container)
        {
            return new EnumMemberNodeWithReflection(declaration, container, semanticModel);
        }

        public EnumNode CreateEnumNode(EnumDeclarationSyntax declaration, ITypeContainer container)
        {
            return new EnumNodeWithReflection(declaration, container, semanticModel);
        }

        public EventNode CreateEventNode(EventFieldDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new EventNodeWithReflection(declaration, container, semanticModel);
        }

        public EventPropertyNode CreateEventPropertyNode(EventDeclarationSyntax declaration, IMemberContainer container)
        {
            return new EventPropertyNodeWithReflection(declaration, container, semanticModel);
        }

        public FieldNode CreateFieldNode(FieldDeclarationSyntax declaration, IMemberContainer container)
        {
            return new FieldNodeWithReflection(declaration, container, semanticModel);
        }

        public IndexerNode CreateIndexerNode(IndexerDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new IndexerNodeWithReflection(declaration, container, semanticModel);
        }

        public InterfaceDeclarationNode CreateInterfaceDeclarationNode(
            InterfaceDeclarationSyntax declaration,
            ITypeContainer container)
        {
            return new InterfaceDeclarationNodeWithReflection(declaration, container, semanticModel);
        }

        public InterfaceNode CreateInterfaceNode(InterfaceDeclarationSyntax declaration, ITypeContainer container)
        {
            return new InterfaceNodeWithReflection(declaration, container);
        }

        public MethodNode CreateMethodNode(MethodDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new MethodNodeWithReflection(declaration, container, semanticModel);
        }

        public NamespaceNode CreateNamespaceNode(string namespaceName)
        {
            return new NamespaceNodeWithReflection(namespaceName);
        }

        public OperatorOverloadNode CreateOperatorOverloadNode(
            OperatorDeclarationSyntax declaration,
            IMemberContainer container)
        {
            return new OperatorOverloadNodeWithReflection(declaration, container, semanticModel);
        }

        public ProjectNode CreateProjectNode(Project project, SolutionNode solution)
        {
            return new ProjectNodeWithReflection(project, solution, assemblyLoader);
        }

        public PropertyNode CreatePropertyNode(PropertyDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new PropertyNodeWithReflection(declaration, container, semanticModel);
        }

        public StructDeclarationNode CreateStructDeclarationNode(
            StructDeclarationSyntax declaration,
            ITypeContainer container)
        {
            return new StructDeclarationNodeWithReflection(declaration, container, semanticModel);
        }

        public StructNode CreateStructNode(StructDeclarationSyntax declaration, ITypeContainer container)
        {
            return new StructNodeWithReflection(declaration, container);
        }
    }
}
