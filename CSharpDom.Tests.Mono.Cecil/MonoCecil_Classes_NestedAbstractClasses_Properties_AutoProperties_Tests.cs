using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicAutoProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedAbstractClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideAutoProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithVirtualAutoProperty));
        }
    }
}
