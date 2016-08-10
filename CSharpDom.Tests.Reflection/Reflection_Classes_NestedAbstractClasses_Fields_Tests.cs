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
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVolatileField));
        }
    }
}
