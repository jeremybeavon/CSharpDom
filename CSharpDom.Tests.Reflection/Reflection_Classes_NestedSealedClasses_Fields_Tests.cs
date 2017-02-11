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
            TestClass(typeof(ClassWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithVolatileField));
        }
    }
}
