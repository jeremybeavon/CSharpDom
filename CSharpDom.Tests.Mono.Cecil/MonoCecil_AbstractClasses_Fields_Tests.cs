using CSharpDom.TestTarget.AbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithConstFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithVolatileField));
        }
    }
}
