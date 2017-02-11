using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithConstFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVolatileField));
        }
    }
}
