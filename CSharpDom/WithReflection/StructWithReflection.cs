using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public sealed class StructWithReflection : TypeWithReflection
    {
        private readonly IStructWithReflection @struct;

        public StructWithReflection(IStructWithReflection @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public IReadOnlyCollection<StructDeclarationWithReflection> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<StructDeclarationWithReflection, IStructDeclarationWithReflection>(
                    @struct.Declarations,
                    declaration => new StructDeclarationWithReflection(declaration));
            }
        }

        public int GenericParameterCount
        {
            get { return @struct.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @struct.IsGeneric; }
        }

        public string Name
        {
            get { return @struct.Name; }
        }

        public NamespaceWithReflection Namespace
        {
            get { return new NamespaceWithReflection(@struct.Namespace); }
        }

        public ProjectWithReflection Project
        {
            get { return ProjectWithReflection.GetProject(@struct.Project); }
        }

        public SolutionWithReflection Solution
        {
            get { return SolutionWithReflection.GetSolution(@struct.Solution); }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @struct.Symbol; }
        }

        public void Accept(ReflectionVisitor visitor)
        {
            @struct.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return @struct.ToString();
        }
    }
}
