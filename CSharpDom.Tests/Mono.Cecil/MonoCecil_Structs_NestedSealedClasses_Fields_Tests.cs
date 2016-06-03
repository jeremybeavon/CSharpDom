using CSharpDom.TestTarget.Structs.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithConstFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithVolatileField));
        }
    }
}
