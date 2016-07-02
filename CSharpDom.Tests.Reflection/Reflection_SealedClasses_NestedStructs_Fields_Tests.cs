using CSharpDom.TestTarget.SealedClasses.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithConstFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithVolatileField));
        }
    }
}
