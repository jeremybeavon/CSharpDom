using CSharpDom.TestTarget.Structs.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivatePropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticProperty));
        }
    }
}
