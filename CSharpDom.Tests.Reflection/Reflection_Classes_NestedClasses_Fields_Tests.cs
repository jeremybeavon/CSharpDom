using CSharpDom.TestTarget.Classes.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithConstFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithVolatileField));
        }
    }
}
