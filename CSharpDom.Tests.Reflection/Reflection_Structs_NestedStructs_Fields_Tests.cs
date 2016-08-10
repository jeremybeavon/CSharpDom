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
            TestStructAsync(typeof(StructWithNestedStructWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithReadOnlyFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticReadOnlyFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticVolatileField));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithVolatileField));
        }
    }
}
