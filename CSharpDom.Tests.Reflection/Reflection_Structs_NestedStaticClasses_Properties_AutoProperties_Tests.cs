using CSharpDom.TestTarget.Structs.NestedStaticClasses.Properties.AutoProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_Properties_AutoProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateAutoProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicAutoPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicAutoProperty));
        }
    }
}
