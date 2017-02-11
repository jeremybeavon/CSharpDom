using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedStaticClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivatePropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPublicProperty));
        }
    }
}
