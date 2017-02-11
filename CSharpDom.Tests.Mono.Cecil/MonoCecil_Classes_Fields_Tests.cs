using CSharpDom.TestTarget.Classes.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithConstFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithInternalFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNewFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNewStaticFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithPrivateFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithProtectedFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithPublicFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithStaticFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithVolatileField));
        }
    }
}
