using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithConstFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
