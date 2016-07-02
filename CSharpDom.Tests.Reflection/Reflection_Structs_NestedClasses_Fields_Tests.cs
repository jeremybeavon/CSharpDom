using CSharpDom.TestTarget.Structs.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithConstFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVolatileField));
        }
    }
}
