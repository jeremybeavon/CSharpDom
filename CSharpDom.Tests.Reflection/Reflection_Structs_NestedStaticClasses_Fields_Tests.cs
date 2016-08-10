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
            TestStructAsync(typeof(StructWithNestedStaticClassWithConstField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithReadOnlyFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithReadOnlyField));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithVolatileFieldUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithVolatileField));
        }
    }
}
