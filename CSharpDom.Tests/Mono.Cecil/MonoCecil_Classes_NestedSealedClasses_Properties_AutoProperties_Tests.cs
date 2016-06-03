using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
