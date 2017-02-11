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
            TestClass(typeof(ClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithVolatileField));
        }
    }
}
