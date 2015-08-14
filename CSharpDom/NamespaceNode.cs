using System.Collections.ObjectModel;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class NamespaceNode : TypeContainer
    {
        protected NamespaceNode(string name)
        {
            Name = name;
            Declarations = new Collection<NamespaceDeclarationSyntax>();
        }

        public string Name { get; private set; }

        public Collection<NamespaceDeclarationSyntax> Declarations { get; private set; }

        public override void Accept(NodeVisitor visitor)
        {
            base.Accept(visitor);
            VisitCollection(Classes, visitor.VisitClass);
            VisitCollection(Delegates, visitor.VisitDelegate);
            VisitCollection(Enums, visitor.VisitEnum);
            VisitCollection(Interfaces, visitor.VisitInterface);
            VisitCollection(Structs, visitor.VisitStruct);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
