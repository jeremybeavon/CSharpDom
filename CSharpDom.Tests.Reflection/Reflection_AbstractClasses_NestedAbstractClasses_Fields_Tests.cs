using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithConstFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
