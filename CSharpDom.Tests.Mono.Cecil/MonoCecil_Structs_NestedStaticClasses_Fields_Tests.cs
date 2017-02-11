using CSharpDom.TestTarget.Structs.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStaticClasses_Fields_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithConstFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithVolatileField));
        }
    }
}
