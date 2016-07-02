using CSharpDom.TestTarget.Structs.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithConstFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithVolatileField));
        }
    }
}
