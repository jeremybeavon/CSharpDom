using CSharpDom.TestTarget.Structs.NestedStaticClasses.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivatePropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicProperty));
        }
    }
}
