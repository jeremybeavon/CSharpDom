using CSharpDom.TestTarget.Structs.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithConstFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithReadOnlyFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticReadOnlyFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithVolatileField));
        }
    }
}
