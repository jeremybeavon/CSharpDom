using CSharpDom.TestTarget.Classes.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
