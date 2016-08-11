using CSharpDom.TestTarget.StaticClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualProperty));
        }
    }
}
