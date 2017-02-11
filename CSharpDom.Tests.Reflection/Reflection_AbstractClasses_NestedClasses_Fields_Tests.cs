using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithConstFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVolatileFieldUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithVolatileField));
        }
    }
}
