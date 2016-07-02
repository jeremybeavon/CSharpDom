using CSharpDom.TestTarget.Structs.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithConstFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithReadOnlyFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithVolatileField));
        }
    }
}
