using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicAutoPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
