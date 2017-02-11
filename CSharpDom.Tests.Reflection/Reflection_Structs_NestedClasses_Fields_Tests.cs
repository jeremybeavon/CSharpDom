using CSharpDom.TestTarget.Structs.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithConstFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithReadOnlyFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithVolatileField));
        }
    }
}
