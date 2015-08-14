using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax.Internal
{
    internal sealed class SyntaxNodeFactory : INodeFactory
    {
        public static readonly INodeFactory Instance = new SyntaxNodeFactory();

        public ClassDeclarationNode CreateClassDeclarationNode(
            ClassDeclarationSyntax declaration,
            ITypeContainer container)
        {
            return new ClassDeclarationNodeWithSyntax(declaration, container);
        }

        public ClassNode CreateClassNode(ClassDeclarationSyntax declaration, ITypeContainer container)
        {
            return new ClassNodeWithSyntax(declaration, container);
        }

        public ConstructorNode CreateConstructorNode(ConstructorDeclarationSyntax declaration, IMemberContainer container)
        {
            return new ConstructorNodeWithSyntax(declaration, container);
        }

        public ConversionOperatorNode CreateConversionOperatorNode(
            ConversionOperatorDeclarationSyntax declaration,
            IMemberContainer container)
        {
            return new ConversionOperatorNodeWithSyntax(declaration, container);
        }

        public DelegateNode CreateDelegateNode(DelegateDeclarationSyntax declaration, ITypeContainer container)
        {
            return new DelegateNodeWithSyntax(declaration, container);
        }

        public DestructorNode CreateDestructorNode(DestructorDeclarationSyntax declaration, ClassDeclarationNode container)
        {
            return new DestructorNodeWithSyntax(declaration, container);
        }

        public DocumentNode CreateDocumentNode(Document document, ProjectNode project)
        {
            return new DocumentNodeWithSyntax(document, project);
        }

        public EnumMemberNode CreateEnumMemberNode(EnumMemberDeclarationSyntax declaration, EnumNode container)
        {
            return new EnumMemberNodeWithSyntax(declaration, container);
        }

        public EnumNode CreateEnumNode(EnumDeclarationSyntax declaration, ITypeContainer container)
        {
            return new EnumNodeWithSyntax(declaration, container);
        }

        public EventNode CreateEventNode(EventFieldDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new EventNodeWithSyntax(declaration, container);
        }

        public EventPropertyNode CreateEventPropertyNode(EventDeclarationSyntax declaration, IMemberContainer container)
        {
            return new EventPropertyNodeWithSyntax(declaration, container);
        }

        public FieldNode CreateFieldNode(FieldDeclarationSyntax declaration, IMemberContainer container)
        {
            return new FieldNodeWithSyntax(declaration, container);
        }

        public IndexerNode CreateIndexerNode(IndexerDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new IndexerNodeWithSyntax(declaration, container);
        }

        public InterfaceDeclarationNode CreateInterfaceDeclarationNode(
            InterfaceDeclarationSyntax declaration,
            ITypeContainer container)
        {
            return new InterfaceDeclarationNodeWithSyntax(declaration, container);
        }

        public InterfaceNode CreateInterfaceNode(InterfaceDeclarationSyntax declaration, ITypeContainer container)
        {
            return new InterfaceNodeWithSyntax(declaration, container);
        }

        public MethodNode CreateMethodNode(MethodDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new MethodNodeWithSyntax(declaration, container);
        }

        public NamespaceNode CreateNamespaceNode(string namespaceName)
        {
            return new NamespaceNodeWithSyntax(namespaceName);
        }

        public OperatorOverloadNode CreateOperatorOverloadNode(
            OperatorDeclarationSyntax declaration,
            IMemberContainer container)
        {
            return new OperatorOverloadNodeWithSyntax(declaration, container);
        }

        public ProjectNode CreateProjectNode(Project project, SolutionNode solution)
        {
            return new ProjectNodeWithSyntax(project, solution);
        }

        public PropertyNode CreatePropertyNode(PropertyDeclarationSyntax declaration, IBasicMemberContainer container)
        {
            return new PropertyNodeWithSyntax(declaration, container);
        }

        public StructDeclarationNode CreateStructDeclarationNode(
            StructDeclarationSyntax declaration,
            ITypeContainer container)
        {
            return new StructDeclarationNodeWithSyntax(declaration, container);
        }

        public StructNode CreateStructNode(StructDeclarationSyntax declaration, ITypeContainer container)
        {
            return new StructNodeWithSyntax(declaration, container);
        }
    }
}
