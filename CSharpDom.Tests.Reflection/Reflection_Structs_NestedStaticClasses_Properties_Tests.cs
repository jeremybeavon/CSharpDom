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
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivatePropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicProperty));
        }
    }
}
