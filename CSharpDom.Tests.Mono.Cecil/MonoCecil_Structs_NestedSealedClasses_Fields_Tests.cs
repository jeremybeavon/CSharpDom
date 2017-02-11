using CSharpDom.TestTarget.Structs.NestedSealedClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithConstFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithVolatileField));
        }
    }
}
