using CSharpDom.TestTarget.Classes.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithConstFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVolatileField));
        }
    }
}
