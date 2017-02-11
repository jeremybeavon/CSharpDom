using CSharpDom.TestTarget.Classes.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithConstFieldUsingReflection()
        {
            TestClass(typeof(ClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithInternalFieldUsingReflection()
        {
            TestClass(typeof(ClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNewFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNewStaticFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNewVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithPrivateFieldUsingReflection()
        {
            TestClass(typeof(ClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithProtectedFieldUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalFieldUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithPublicFieldUsingReflection()
        {
            TestClass(typeof(ClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithStaticFieldUsingReflection()
        {
            TestClass(typeof(ClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithStaticVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithVolatileField));
        }
    }
}
