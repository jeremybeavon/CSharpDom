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
            TestStruct(typeof(StructWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivatePropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticProperty));
        }
    }
}
