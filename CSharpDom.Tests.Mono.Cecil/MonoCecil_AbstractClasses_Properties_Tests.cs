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
            TestAbstractClassAsync(typeof(AbstractClassWithInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithOverridePropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivatePropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualProperty));
        }
    }
}
