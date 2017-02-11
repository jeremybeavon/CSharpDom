using CSharpDom.TestTarget.Structs.NestedStaticClasses.Fields;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_Fields_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithConstFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithReadOnlyFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithVolatileFieldUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithVolatileField));
        }
    }
}
