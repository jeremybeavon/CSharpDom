using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithConstFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
