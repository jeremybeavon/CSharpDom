using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithConstFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithVolatileField));
        }
    }
}
