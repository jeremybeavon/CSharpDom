using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithConstFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
