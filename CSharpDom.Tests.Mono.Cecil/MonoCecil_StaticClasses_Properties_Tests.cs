using CSharpDom.TestTarget.StaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithInternalPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPublicPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicProperty));
        }
    }
}
