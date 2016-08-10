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
            TestStructAsync(typeof(StructWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithReadOnlyFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithVolatileFieldUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithVolatileField));
        }
    }
}
