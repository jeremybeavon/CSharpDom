using CSharpDom.TestTarget.Classes.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithInternalPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public async Task TestClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    await TestClassAsync(typeof(ClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public async Task TestClassWithOverridePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithPublicPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithStaticPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithVirtualPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithVirtualProperty));
        }
    }
}
