using CSharpDom.TestTarget.Structs.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_Properties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithInternalPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithInternalProperty));
        }

        [TestMethod]
        public async Task TestStructWithPrivatePropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPrivateProperty));
        }

        [TestMethod]
        public async Task TestStructWithPublicPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPublicProperty));
        }

        [TestMethod]
        public async Task TestStructWithStaticPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithStaticProperty));
        }
    }
}
