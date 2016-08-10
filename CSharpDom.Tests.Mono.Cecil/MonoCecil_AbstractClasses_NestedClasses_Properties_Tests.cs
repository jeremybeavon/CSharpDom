using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualProperty));
        }
    }
}
