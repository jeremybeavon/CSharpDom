using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithConstFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithVolatileField));
        }
    }
}
