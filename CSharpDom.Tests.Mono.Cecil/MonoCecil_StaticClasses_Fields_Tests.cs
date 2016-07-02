using CSharpDom.TestTarget.StaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithConstrFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithConstrField));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalField));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateField));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicField));
        }

        [TestMethod]
        public async Task TestStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithReadOnlyField));
        }

        [TestMethod]
        public async Task TestStaticClassWithVolatileFieldUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithVolatileField));
        }
    }
}
