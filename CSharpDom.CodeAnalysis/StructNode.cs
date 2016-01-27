using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class StructNode : TypeNode<StructDeclarationNode, StructDeclarationSyntax>
    {
        protected StructNode(StructDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        public ICompositeType DeclaringType
        {
            get
            {
                IHasCompositeType hasCompositeType = Container as IHasCompositeType;
                return hasCompositeType == null ? null : hasCompositeType.CompositeType;
            }
        }

        public bool IsGeneric
        {
            get { return GenericParameterCount != 0; }
        }

        public NamespaceNode Namespace
        {
            get { return Container as NamespaceNode; }
        }

        public ProjectNode Project
        {
            get { return ((IHasProject<ProjectNode>)Declarations[0].Container).Project; }
        }

        public SolutionNode Solution
        {
            get { return Project.Solution; }
        }
    }
}
