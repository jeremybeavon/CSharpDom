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
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
