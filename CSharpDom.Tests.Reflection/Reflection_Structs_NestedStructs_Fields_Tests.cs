using CSharpDom.TestTarget.Structs.NestedStructs.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithConstFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithReadOnlyFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticReadOnlyFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithVolatileField));
        }
    }
}
