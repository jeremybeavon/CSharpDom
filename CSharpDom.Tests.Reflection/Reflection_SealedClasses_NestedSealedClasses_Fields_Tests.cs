using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithConstFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithVolatileField));
        }
    }
}
