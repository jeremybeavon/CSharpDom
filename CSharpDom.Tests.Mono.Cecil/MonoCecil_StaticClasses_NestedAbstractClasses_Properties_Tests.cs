using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedAbstractClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedAbstractClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOverridePropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivatePropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVirtualPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualProperty));
        }
    }
}
