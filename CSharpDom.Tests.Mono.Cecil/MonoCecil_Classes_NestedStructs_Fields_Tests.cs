using CSharpDom.TestTarget.Classes.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithConstFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithVolatileField));
        }
    }
}
