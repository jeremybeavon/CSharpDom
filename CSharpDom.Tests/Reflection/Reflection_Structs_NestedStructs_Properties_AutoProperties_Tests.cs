using CSharpDom.TestTarget.Structs.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticAutoProperty));
        }
    }
}
