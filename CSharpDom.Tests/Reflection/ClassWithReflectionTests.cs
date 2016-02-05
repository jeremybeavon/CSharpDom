using CSharpDom.Common;
using CSharpDom.Reflection;
using CSharpDom.Tests.Common;
using CSharpDom.TestTarget.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class ClassWithReflectionTests : AbstractClassTests
    {
        private ISolution solution;

        [TestInitialize]
        public void SetUp()
        {
            solution = new AssemblyWithReflection(typeof(PublicClass).Assembly).AsSolution();
        }

        public override ISolution Solution
        {
            get { return solution; }
        }

        [TestMethod]
        public async Task TestPublicClassWithReflectionAsync()
        {
            await TestPublicClassAsync();
        }
    }
}
