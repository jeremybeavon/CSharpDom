using CSharpDom.TestTarget.Classes.NestedStructs.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticAutoProperty));
        }
    }
}
