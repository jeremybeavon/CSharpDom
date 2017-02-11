using CSharpDom.TestTarget.AbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicAutoProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideAutoProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithVirtualAutoProperty));
        }
    }
}
