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
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVirtualProperty));
        }
    }
}
