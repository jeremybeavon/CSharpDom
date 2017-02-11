using CSharpDom.TestTarget.AbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithConstFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithVolatileField));
        }
    }
}
