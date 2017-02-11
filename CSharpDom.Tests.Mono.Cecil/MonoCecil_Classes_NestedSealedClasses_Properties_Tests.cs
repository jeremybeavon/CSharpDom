using CSharpDom.TestTarget.Classes.NestedSealedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverridePropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
