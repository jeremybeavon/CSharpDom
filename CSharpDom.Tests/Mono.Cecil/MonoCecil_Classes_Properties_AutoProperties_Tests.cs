using CSharpDom.TestTarget.Classes.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithVirtualAutoProperty));
        }
    }
}
