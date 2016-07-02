using CSharpDom.TestTarget.Classes.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
