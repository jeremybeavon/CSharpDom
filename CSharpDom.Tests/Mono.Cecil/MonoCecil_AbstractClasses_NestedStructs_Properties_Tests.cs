using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivatePropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticProperty));
        }
    }
}
