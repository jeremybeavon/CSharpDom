using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
