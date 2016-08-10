using CSharpDom.TestTarget.Structs.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithVolatileField));
        }
    }
}
