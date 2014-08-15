using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;

namespace CSharpDom.WithReflection
{
    public sealed class InterfaceWithReflection : BasicTypeWithReflection
    {
        private readonly IInterfaceWithReflection @interface;

        public InterfaceWithReflection(IInterfaceWithReflection @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public IReadOnlyCollection<InterfaceDeclarationWithReflection> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<InterfaceDeclarationWithReflection, IInterfaceDeclarationWithReflection>(
                    @interface.Declarations,
                    declaration => new InterfaceDeclarationWithReflection(declaration));
            }
        }

        public int GenericParameterCount
        {
            get { return @interface.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @interface.IsGeneric; }
        }

        public string Name
        {
            get { return @interface.Name; }
        }

        public NamespaceWithReflection Namespace
        {
            get { return new NamespaceWithReflection(@interface.Namespace); }
        }

        public ProjectWithReflection Project
        {
            get { return ProjectWithReflection.GetProject(@interface.Project); }
        }

        public SolutionWithReflection Solution
        {
            get { return SolutionWithReflection.GetSolution(@interface.Solution); }
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @interface.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @interface.ToString();
        }
    }
}
