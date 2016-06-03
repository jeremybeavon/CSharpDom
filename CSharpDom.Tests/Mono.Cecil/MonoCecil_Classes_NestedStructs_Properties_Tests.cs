using CSharpDom.TestTarget.Classes.NestedStructs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivatePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticProperty));
        }
    }
}
