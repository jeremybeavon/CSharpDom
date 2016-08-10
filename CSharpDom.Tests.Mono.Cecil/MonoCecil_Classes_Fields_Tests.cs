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
            TestClassAsync(typeof(ClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithInternalFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNewFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNewStaticFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithPrivateFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithProtectedFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithPublicFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithStaticFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithVolatileField));
        }
    }
}
