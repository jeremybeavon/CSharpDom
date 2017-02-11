using CSharpDom.TestTarget.Structs.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivatePropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPublicProperty));
        }
    }
}
