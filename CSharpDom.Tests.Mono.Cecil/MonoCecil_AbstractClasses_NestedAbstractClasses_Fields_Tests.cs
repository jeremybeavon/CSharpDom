using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithConstFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
