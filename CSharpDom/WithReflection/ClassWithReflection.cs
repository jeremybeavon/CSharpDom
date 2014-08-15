using System.Collections.Generic;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public sealed class ClassWithReflection : TypeWithReflection
    {
        private readonly IClassWithReflection @class;

        public ClassWithReflection(IClassWithReflection @class)
            : base(@class)
        {
            this.@class = @class;
        }

        public IReadOnlyCollection<ClassDeclarationWithReflection> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<ClassDeclarationWithReflection, IClassDeclarationWithReflection>(
                    @class.Declarations,
                    declaration => new ClassDeclarationWithReflection(declaration));
            }    
        }

        public DestructorWithReflection Destructor
        {
            get { return new DestructorWithReflection(@class.Destructor); }
        }

        public int GenericParameterCount
        {
            get { return @class.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @class.IsGeneric; }
        }

        public string Name
        {
            get { return @class.Name; }
        }

        public NamespaceWithReflection Namespace
        {
            get { return new NamespaceWithReflection(@class.Namespace); }
        }

        public ProjectWithReflection Project
        {
            get { return ProjectWithReflection.GetProject(@class.Project); }
        }

        public SolutionWithReflection Solution
        {
            get { return SolutionWithReflection.GetSolution(@class.Solution); }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @class.Symbol; }
        }

        public IClassWithReflection AsInterface()
        {
            return @class;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @class.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @class.ToString();
        }
    }
}
