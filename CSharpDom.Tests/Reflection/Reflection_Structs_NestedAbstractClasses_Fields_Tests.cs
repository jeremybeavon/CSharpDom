using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVolatileField));
        }
    }
}
