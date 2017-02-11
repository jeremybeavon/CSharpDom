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
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithVolatileField));
        }
    }
}
