using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVirtualPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverridePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
