using System;
using System.Linq;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class ClassNode : TypeNode<ClassDeclarationNode, ClassDeclarationSyntax>
    {
        public ClassNode(ClassDeclarationSyntax declaration, ITypeContainer container)
            : base(declaration, container)
        {
        }

        public DestructorNode Destructor
        {
            get
            {
                return Declarations
                    .Select(declaration => declaration.Destructor)
                    .FirstOrDefault(destructor => destructor != null);
            }
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

        public override void Accept(NodeVisitor visitor)
        {
            base.Accept(visitor);
            if (IsNestedType)
            {
                VisitCollection(Declarations, visitor.VisitNestedClassDeclaration);
            }
            else
            {
                VisitCollection(Declarations, visitor.VisitClassDeclaration);
            }
        }
    }
}
