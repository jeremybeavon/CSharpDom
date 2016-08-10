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
            TestClassAsync(typeof(ClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithInternalFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNewFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNewStaticFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNewVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithPrivateFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithProtectedFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithPublicFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithStaticFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithStaticVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithVolatileField));
        }
    }
}
