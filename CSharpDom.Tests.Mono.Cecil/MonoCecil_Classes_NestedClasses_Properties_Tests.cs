using CSharpDom.TestTarget.Classes.NestedClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Properties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithInternalPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticProperty));
        }

        //[TestMethod]
        //public void TestClassWithNestedClassWithNewVirtualPropertyUsingMonoCecil()
        //{
        //    TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualProperty));
        //}

        [TestMethod]
        public void TestClassWithNestedClassWithOverridePropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivatePropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverridePropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticProperty));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualProperty));
        }
    }
}
