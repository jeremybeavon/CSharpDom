using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
