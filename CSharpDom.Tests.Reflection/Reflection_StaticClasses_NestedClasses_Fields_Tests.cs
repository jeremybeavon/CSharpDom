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
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVolatileField));
        }
    }
}
