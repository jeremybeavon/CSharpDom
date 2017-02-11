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
            TestStruct(typeof(StructWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithReadOnlyFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithVolatileField));
        }
    }
}
