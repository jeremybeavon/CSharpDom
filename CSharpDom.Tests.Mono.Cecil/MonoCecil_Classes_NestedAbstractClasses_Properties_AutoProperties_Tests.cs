using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
