using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public sealed class DelegateWithReflection
    {
        private readonly IDelegateWithReflection @delegate;

        public DelegateWithReflection(IDelegateWithReflection @delegate)
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

        public NamespaceWithReflection Namespace
        {
            get { return new NamespaceWithReflection(@delegate.Namespace); }
        }

        public ProjectWithReflection Project
        {
            get { return ProjectWithReflection.GetProject(@delegate.Project); }
        }

        public SolutionWithReflection Solution
        {
            get { return SolutionWithReflection.GetSolution(@delegate.Solution); }
        }

        public int StartLine
        {
            get { return @delegate.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @delegate.Symbol; }
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @delegate.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @delegate.ToString();
        }
    }
}
