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
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithVolatileField));
        }
    }
}
