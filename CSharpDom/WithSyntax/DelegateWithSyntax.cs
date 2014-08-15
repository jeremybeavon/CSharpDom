using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax
{
    public sealed class DelegateWithSyntax : AbstractSyntaxNode<IDelegateSyntax>
    {
        private readonly IDelegateSyntax @delegate;

        public DelegateWithSyntax(IDelegateSyntax @delegate)
            : base(@delegate)
        {
            this.@delegate = @delegate;
        }

        public DelegateDeclarationSyntax Declaration
        {
            get { return @delegate.Declaration; }
        }

        public int EndLine
        {
            get { return @delegate.EndLine; }
        }

        public int GenericParameterCount
        {
            get { return @delegate.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @delegate.IsGeneric; }
        }

        public string Name
        {
            get { return @delegate.Name; }
        }

        public NamespaceWithSyntax Namespace
        {
            get { return new NamespaceWithSyntax(@delegate.Namespace); }
        }

        public ProjectWithSyntax Project
        {
            get { return ProjectWithSyntax.GetProject(@delegate.Project); }
        }

        public SolutionWithSyntax Solution
        {
            get { return SolutionWithSyntax.GetSolution(@delegate.Solution); }
        }

        public int StartLine
        {
            get { return @delegate.StartLine; }
        }

        public override void Accept(SyntaxVisitor visitor)
        {
            @delegate.Accept(new SyntaxVisitorMapping(visitor));
        }

        public override void Visit(SyntaxVisitor visitor)
        {
            visitor.VisitDelegate(this);
        }
    }
}
