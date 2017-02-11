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
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithVirtualProperty));
        }
    }
}
