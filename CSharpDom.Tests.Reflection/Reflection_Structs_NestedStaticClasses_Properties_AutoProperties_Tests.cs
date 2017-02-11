using CSharpDom.TestTarget.Structs.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicAutoPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
