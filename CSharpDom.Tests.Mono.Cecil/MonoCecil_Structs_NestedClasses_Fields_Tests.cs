using CSharpDom.TestTarget.Structs.NestedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithConstFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithVolatileField));
        }
    }
}
