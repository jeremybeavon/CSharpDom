using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Builder
{
    internal sealed class SyntaxBuilder : CSharpSyntaxWalker
    {
        private EnumNode currentEnumNode;

        public SyntaxBuilder(INodeFactory nodeFactory, ITypeContainer rootDeclarationTypeContainer)
        {
            NodeFactory = nodeFactory;
            EmptyNamespace = nodeFactory.CreateNamespaceNode(string.Empty);
            NamespaceStack = new Stack<NamespaceNode>();
            NamespaceNameStack = new Stack<string>();
            NamespacesByName = new Dictionary<string, NamespaceNode>();
            TypeContainer = new Stack<ITypeContainer>();
            DeclarationTypeContainer = new Stack<ITypeContainer>();
            BasicMemberContainer = new Stack<IBasicMemberContainer>();
            MemberContainer = new Stack<IMemberContainer>();
            NamespaceStack.Push(EmptyNamespace);
            NamespacesByName.Add(string.Empty, EmptyNamespace);
            DeclarationTypeContainer.Push(rootDeclarationTypeContainer);
        }

        public INodeFactory NodeFactory { get; private set; }

        public NamespaceNode EmptyNamespace { get; private set; }

        public Stack<NamespaceNode> NamespaceStack { get; private set; }

        public Stack<string> NamespaceNameStack { get; private set; }

        public Dictionary<string, NamespaceNode> NamespacesByName { get; private set; }

        public Stack<ITypeContainer> TypeContainer { get; private set; }

        public Stack<ITypeContainer> DeclarationTypeContainer { get; private set; }

        public Stack<IBasicMemberContainer> BasicMemberContainer { get; private set; }

        public Stack<IMemberContainer> MemberContainer { get; private set; }

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            using (new ClassContainer(node, this))
            {
                base.VisitClassDeclaration(node);
            }
        }

        public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        {
            IMemberContainer container = MemberContainer.Peek();
            container.Constructors.Add(NodeFactory.CreateConstructorNode(node, container));
        }

        public override void VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
        {
            IMemberContainer container = MemberContainer.Peek();
            container.ConversionOperators.Add(NodeFactory.CreateConversionOperatorNode(node, container));
        }

        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        {
            ITypeContainer container = TypeContainer.Peek();
            ITypeContainer declarationTypeContainer = DeclarationTypeContainer.Peek();
            DelegateNode delegateNode = NodeFactory.CreateDelegateNode(node, container);
            container.Delegates.Add(delegateNode);
            if (container != declarationTypeContainer)
            {
                declarationTypeContainer.Delegates.Add(delegateNode);
                delegateNode.DeclarationTypeContainer = declarationTypeContainer;
            }
        }

        public override void VisitDestructorDeclaration(DestructorDeclarationSyntax node)
        {
            ClassDeclarationNode container = (ClassDeclarationNode)MemberContainer.Peek();
            container.Destructor = NodeFactory.CreateDestructorNode(node, container);
        }

        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            ITypeContainer container = TypeContainer.Peek();
            ITypeContainer declarationTypeContainer = DeclarationTypeContainer.Peek();
            EnumNode enumNode = NodeFactory.CreateEnumNode(node, container);
            container.Enums.Add(enumNode);
            if (container != declarationTypeContainer)
            {
                declarationTypeContainer.Enums.Add(enumNode);
                enumNode.DeclarationTypeContainer = declarationTypeContainer;
            }

            currentEnumNode = enumNode;
            base.VisitEnumDeclaration(node);
            currentEnumNode = null;
        }

        public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            currentEnumNode.EnumMembers.Add(NodeFactory.CreateEnumMemberNode(node, currentEnumNode));
        }

        public override void VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
        {
            IBasicMemberContainer container = BasicMemberContainer.Peek();
            container.Events.Add(NodeFactory.CreateEventNode(node, container));
        }

        public override void VisitEventDeclaration(EventDeclarationSyntax node)
        {
            IMemberContainer container = MemberContainer.Peek();
            container.EventProperties.Add(NodeFactory.CreateEventPropertyNode(node, container));
        }

        public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            IMemberContainer container = MemberContainer.Peek();
            container.Fields.Add(NodeFactory.CreateFieldNode(node, container));
        }

        public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)
        {
            IBasicMemberContainer container = BasicMemberContainer.Peek();
            container.Indexers.Add(NodeFactory.CreateIndexerNode(node, container));
        }

        public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            using (new InterfaceContainer(node, this))
            {
                base.VisitInterfaceDeclaration(node);
            }
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            IBasicMemberContainer container = BasicMemberContainer.Peek();
            container.Methods.Add(NodeFactory.CreateMethodNode(node, container));
        }

        public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
        {
            using (new NamespaceContainer(node, this))
            {
                base.VisitNamespaceDeclaration(node);
            }
        }

        public override void VisitOperatorDeclaration(OperatorDeclarationSyntax node)
        {
            IMemberContainer container = MemberContainer.Peek();
            container.OperatorOverloads.Add(NodeFactory.CreateOperatorOverloadNode(node, container));
        }

        public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            IBasicMemberContainer container = BasicMemberContainer.Peek();
            container.Properties.Add(NodeFactory.CreatePropertyNode(node, container));
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            using (new StructContainer(node, this))
            {
                base.VisitStructDeclaration(node);
            }
        }
    }
}