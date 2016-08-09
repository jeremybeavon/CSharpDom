using CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public async Task TestStaticClassWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualProperty));
        }
    }
}
