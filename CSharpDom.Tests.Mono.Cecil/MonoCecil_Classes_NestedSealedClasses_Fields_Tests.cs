using CSharpDom.TestTarget.Classes.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithVolatileField));
        }
    }
}
