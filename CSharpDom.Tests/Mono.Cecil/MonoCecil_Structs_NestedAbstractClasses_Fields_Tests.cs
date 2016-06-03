using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithConstFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVolatileField));
        }
    }
}
