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
            TestStaticClass(typeof(StaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPublicPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithPublicProperty));
        }
    }
}
