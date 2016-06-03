using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOverridePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
