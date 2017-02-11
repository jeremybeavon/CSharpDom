using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticAutoProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithNewVirtualAutoPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualAutoProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicAutoProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideAutoProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
