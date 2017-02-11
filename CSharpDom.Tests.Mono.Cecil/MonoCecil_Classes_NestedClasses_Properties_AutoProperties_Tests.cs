using CSharpDom.TestTarget.Classes.NestedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewVirtualAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicAutoProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideAutoProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithVirtualAutoProperty));
        }
    }
}
