using CSharpDom.TestTarget.StaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithInternalPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPrivatePropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPublicPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithPublicProperty));
        }
    }
}
