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
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithVolatileField));
        }
    }
}
