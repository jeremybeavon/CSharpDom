using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols.Internal
{
    internal sealed class SymbolNodeFactory : INodeFactory
    {
        private readonly SemanticModel semanticModel;

        public SymbolNodeFactory(SemanticModel semanticModel)
        {
            this.semanticModel = semanticModel;
        }

        public ClassDeclarationNode CreateClassDeclarationNode(
            ClassDeclarationSyntax declaration,
            ITypeContainer container)
        {
            return new ClassDeclarationNodeWithSymbols(declaration, container, semanticModel);
        }

        public ClassNode CreateClassNode(ClassDeclarationSyntax declaration, ITypeContainer container)
        {
            return new ClassNodeWithSymbols(declaration, container);
        }

        public ConstructorNode CreateConstructorNode(ConstructorDeclarationSyntax declaration, IMemberContainer container)
        {
            return new ConstructorNodeWithSymbols(declaration, container, semanticModel);
        }

        public ConversionOperatorNode CreateConversionOperatorNode(
            ConversionOperatorDeclarationSyntax declaration,
            IMemberContainer container)
        {
            return new ConversionOperatorNodeWithSymbols(declaration, container, semanticModel);
        }

        public DelegateNode CreateDelegateNode(DelegateDeclarationSyntax declaration, ITypeContainer container)
        {
            return new DelegateNodeWithSymbols(declaration, container, semanticModel);
        }

        public DestructorNode CreateDestructorNode(DestructorDeclarationSyntax declaration, ClassDeclarationNode container)
        {
            return new DestructorNodeWithSymbols(declaration, container, semanticModel);
        }

        public DocumentNode CreateDocumentNode(Document document, ProjectNode project)
        {
            return new DocumentNodeWithSymbols(document, project);
        }

        public EnumMemberNode CreateEnumMemberNode(EnumMemberDeclarationSyntax declaration, EnumNode container)
        {
            return new EnumMemberNodeWithSymbols(declaration, container, semanticModel);
        }

        public EnumNode CreateEnumNode(EnumDeclarationSyntax declaration, ITypeContainer container)
        {
            return new EnumNodeWithSymbols(declaration, container, semanticModel);
        }

        public EventNode CreateEventNode(EventFieldDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new EventNodeWithSymbols(declaration, container, semanticModel);
        }

        public EventPropertyNode CreateEventPropertyNode(EventDeclarationSyntax declaration, IMemberContainer container)
        {
            return new EventPropertyNodeWithSymbols(declaration, container, semanticModel);
        }

        public FieldNode CreateFieldNode(FieldDeclarationSyntax declaration, IMemberContainer container)
        {
            return new FieldNodeWithSymbols(declaration, container, semanticModel);
        }

        public IndexerNode CreateIndexerNode(IndexerDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new IndexerNodeWithSymbols(declaration, container, semanticModel);
        }

        public InterfaceDeclarationNode CreateInterfaceDeclarationNode(
            InterfaceDeclarationSyntax declaration,
            ITypeContainer container)
        {
            return new InterfaceDeclarationNodeWithSymbols(declaration, container, semanticModel);
        }

        public InterfaceNode CreateInterfaceNode(InterfaceDeclarationSyntax declaration, ITypeContainer container)
        {
            return new InterfaceNodeWithSymbols(declaration, container);
        }

        public MethodNode CreateMethodNode(MethodDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new MethodNodeWithSymbols(declaration, container, semanticModel);
        }

        public NamespaceNode CreateNamespaceNode(string namespaceName)
        {
            return new NamespaceNodeWithSymbols(namespaceName);
        }

        public OperatorOverloadNode CreateOperatorOverloadNode(
            OperatorDeclarationSyntax declaration,
            IMemberContainer container)
        {
            return new OperatorOverloadNodeWithSymbols(declaration, container, semanticModel);
        }

        public ProjectNode CreateProjectNode(Project project, SolutionNode solution)
        {
            return new ProjectNodeWithSymbols(project, solution);
        }

        public PropertyNode CreatePropertyNode(PropertyDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new PropertyNodeWithSymbols(declaration, container, semanticModel);
        }

        public StructDeclarationNode CreateStructDeclarationNode(
            StructDeclarationSyntax declaration,
            ITypeContainer container)
        {
            return new StructDeclarationNodeWithSymbols(declaration, container, semanticModel);
        }

        public StructNode CreateStructNode(StructDeclarationSyntax declaration, ITypeContainer container)
        {
            return new StructNodeWithSymbols(declaration, container);
        }
    }
}
