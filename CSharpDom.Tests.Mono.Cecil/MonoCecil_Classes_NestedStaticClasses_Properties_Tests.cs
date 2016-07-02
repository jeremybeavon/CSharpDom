using CSharpDom.TestTarget.Classes.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStaticClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicProperty));
        }
    }
}
