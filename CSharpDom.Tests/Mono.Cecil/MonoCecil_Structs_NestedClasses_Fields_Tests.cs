using CSharpDom.TestTarget.Structs.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithConstFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVolatileField));
        }
    }
}
