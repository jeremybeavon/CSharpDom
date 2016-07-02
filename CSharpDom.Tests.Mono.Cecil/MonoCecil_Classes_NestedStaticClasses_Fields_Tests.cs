using CSharpDom.TestTarget.Classes.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStaticClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithConstFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithVolatileField));
        }
    }
}
