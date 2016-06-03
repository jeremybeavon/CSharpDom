using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithConstFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithInternalFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPrivateFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPublicFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithReadOnlyFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithVolatileFieldUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithVolatileField));
        }
    }
}
