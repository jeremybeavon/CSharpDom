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
            TestClassAsync(typeof(ClassWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVolatileField));
        }
    }
}
