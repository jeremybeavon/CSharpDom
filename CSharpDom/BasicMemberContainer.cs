using System.Collections.ObjectModel;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class BasicMemberContainer<TDeclaration> : AbstractNode<TDeclaration, ITypeContainer>,
        IBasicMemberContainer, ITypeName, IHasBasicCompositeType
        where TDeclaration : TypeDeclarationSyntax
    {
        protected BasicMemberContainer(TDeclaration declaration, ITypeContainer container)
            : base(declaration, container)
        {
            TypeName = new TypeNameNode(declaration);
            Events = new Collection<EventNode>();
            Indexers = new Collection<IndexerNode>();
            Properties = new Collection<PropertyNode>();
            Methods = new Collection<MethodNode>();
        }

        public TypeNameNode TypeName { get; private set; }

        public string Name
        {
            get { return TypeName.Name; }
        }

        public int GenericParameterCount
        {
            get { return TypeName.GenericParameterCount; }
        }

        public string NameWithGenericParameterCount
        {
            get { return TypeName.NameWithGenericParameterCount; }
        }

        public bool IsNestedType
        {
            get { return !(Container is DocumentNode); }
        }

        public Collection<EventNode> Events { get; private set; }

        public Collection<IndexerNode> Indexers { get; private set; }

        public Collection<PropertyNode> Properties { get; private set; }

        public Collection<MethodNode> Methods { get; private set; }

        public abstract IBasicCompositeType BasicCompositeType { get; }

        public override void Accept(NodeVisitor visitor)
        {
            VisitCollection(Events, visitor.VisitEvent);
            VisitCollection(Indexers, visitor.VisitIndexer);
            VisitCollection(Properties, visitor.VisitProperty);
            VisitCollection(Methods, visitor.VisitMethod);
        }
    }
}
