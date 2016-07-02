using CSharpDom.Common;
using CSharpDom.Mono.Cecil;
using CSharpDom.Mono.Cecil.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using Mono.Cecil;

namespace CSharpDom.Tests.Mono.Cecil
{
    public abstract class AbstractSolutionWithMonoCecilTests : AbstractSolutionTests<ProjectWithMonoCecil>
    {
        private static readonly ISolution<ProjectWithMonoCecil> solution =
            new AssemblyWithMonoCecil(AssemblyDefinition.ReadAssembly(typeof(PublicClass).Assembly.Location)).AsSolution();

        public sealed override ISolution<ProjectWithMonoCecil> Solution
        {
            get { return solution; }
        }
    }
}
