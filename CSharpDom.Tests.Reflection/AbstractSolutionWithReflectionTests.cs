using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;

namespace CSharpDom.Tests.Reflection
{
    public abstract class AbstractSolutionWithReflectionTests : AbstractSolutionTests<ProjectWithReflection>
    {
        private static readonly ISolution<ProjectWithReflection> solution =
            new AssemblyWithReflection(typeof(PublicClass).Assembly).AsSolution();

        public sealed override ISolution<ProjectWithReflection> Solution
        {
            get { return solution; }
        }
    }
}
