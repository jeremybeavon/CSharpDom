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
            TestStructAsync(typeof(StructWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticAutoPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticAutoProperty));
        }
    }
}
