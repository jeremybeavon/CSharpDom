using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithConstFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithVolatileField));
        }
    }
}
