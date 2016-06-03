using CSharpDom.TestTarget.SealedClasses.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithConstFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithVolatileField));
        }
    }
}
