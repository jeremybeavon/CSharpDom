using CSharpDom.TestTarget.Structs.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithInternalAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticAutoProperty));
        }
    }
}
