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
            TestStructAsync(typeof(StructWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithReadOnlyFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticReadOnlyFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithVolatileField));
        }
    }
}
