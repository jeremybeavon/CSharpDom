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
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverridePropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
