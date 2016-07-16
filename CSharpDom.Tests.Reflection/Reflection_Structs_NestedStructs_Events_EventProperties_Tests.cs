using CSharpDom.TestTarget.Structs.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticEventProperty));
        }
    }
}
