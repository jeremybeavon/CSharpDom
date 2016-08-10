using CSharpDom.TestTarget.Structs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithInternalPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithPrivatePropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithPublicPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithStaticPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithStaticProperty));
        }
    }
}
