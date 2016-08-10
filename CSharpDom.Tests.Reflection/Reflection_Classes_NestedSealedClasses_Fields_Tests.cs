using CSharpDom.TestTarget.Classes.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithConstFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithVolatileField));
        }
    }
}
