using CSharpDom.Mono.Cecil;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using Mono.Cecil;

namespace CSharpDom.Tests.Mono.Cecil
{
    public abstract class AbstractSolutionWithMonoCecilTests : AbstractSolutionTests
    {
        private static readonly TypeCache typeCache =
            new TypeCache(new AssemblyWithMonoCecil(AssemblyDefinition.ReadAssembly(typeof(PublicClass).Assembly.Location)).AsSolution());

        public sealed override TypeCache TypeCache
        {
            get { return typeCache; }
        }
    }
}
