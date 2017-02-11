using CSharpDom.TestTarget.StaticClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithConstFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVolatileField));
        }
    }
}
