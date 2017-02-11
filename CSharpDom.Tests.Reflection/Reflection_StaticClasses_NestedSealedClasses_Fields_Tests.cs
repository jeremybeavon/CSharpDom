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
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithVolatileField));
        }
    }
}
