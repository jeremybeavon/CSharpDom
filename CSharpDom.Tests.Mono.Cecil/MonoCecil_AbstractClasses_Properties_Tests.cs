using CSharpDom.TestTarget.AbstractClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithInternalPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithOverridePropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivatePropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithSealedOverridePropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithStaticPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithVirtualProperty));
        }
    }
}
