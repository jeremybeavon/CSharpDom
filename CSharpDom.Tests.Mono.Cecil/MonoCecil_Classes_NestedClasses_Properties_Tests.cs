using CSharpDom.TestTarget.Classes.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public async Task TestClassWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualProperty));
        }
    }
}
