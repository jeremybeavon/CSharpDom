using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithReadOnlyFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticReadOnlyFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVolatileField));
        }
    }
}
