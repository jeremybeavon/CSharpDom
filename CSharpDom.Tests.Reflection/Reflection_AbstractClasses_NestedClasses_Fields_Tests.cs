using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVolatileField));
        }
    }
}
