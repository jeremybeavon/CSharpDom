using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_Properties_AutoProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithSealedOverrideAutoProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticAutoPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticAutoProperty));
        }
    }
}
