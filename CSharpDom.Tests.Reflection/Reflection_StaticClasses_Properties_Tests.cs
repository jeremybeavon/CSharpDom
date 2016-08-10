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
            TestStaticClassAsync(typeof(StaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPrivatePropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPublicPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicProperty));
        }
    }
}
