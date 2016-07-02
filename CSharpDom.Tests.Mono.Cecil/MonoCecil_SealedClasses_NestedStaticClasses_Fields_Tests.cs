using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithConstFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithVolatileField));
        }
    }
}
