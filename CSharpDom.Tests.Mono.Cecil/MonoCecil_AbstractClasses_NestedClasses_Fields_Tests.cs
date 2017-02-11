using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithVolatileField));
        }
    }
}
