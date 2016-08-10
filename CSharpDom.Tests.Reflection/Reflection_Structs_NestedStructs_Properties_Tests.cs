using CSharpDom.TestTarget.Structs.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithInternalPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivatePropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticProperty));
        }
    }
}
