using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedStaticClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithConstFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithVolatileField));
        }
    }
}
