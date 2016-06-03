using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
