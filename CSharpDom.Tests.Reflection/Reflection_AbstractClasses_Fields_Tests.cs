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
            TestAbstractClassAsync(typeof(AbstractClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithReadOnlyFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVolatileField));
        }
    }
}
