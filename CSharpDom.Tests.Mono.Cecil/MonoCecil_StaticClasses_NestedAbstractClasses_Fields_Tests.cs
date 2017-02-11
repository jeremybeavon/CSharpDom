using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
