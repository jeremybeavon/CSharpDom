using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedSealedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverridePropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
