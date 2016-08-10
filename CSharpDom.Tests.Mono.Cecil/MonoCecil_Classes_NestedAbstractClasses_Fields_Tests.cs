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
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
