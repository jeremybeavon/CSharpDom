using CSharpDom.Reflection;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;

namespace CSharpDom.Tests.Reflection
{
    public abstract class AbstractSolutionWithReflectionTests : AbstractSolutionTests
    {
        private static readonly TypeCache typeCache =
            new TypeCache(new AssemblyWithReflection(typeof(PublicClass).Assembly).AsSolution());

        public sealed override TypeCache TypeCache
        {
            get { return typeCache; }
        }
    }
}
