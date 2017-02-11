using CSharpDom.TestTarget.Structs.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithConstFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithReadOnlyFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithVolatileField));
        }
    }
}
