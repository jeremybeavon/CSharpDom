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
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverridePropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticProperty));
        }
    }
}
