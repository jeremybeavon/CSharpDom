using CSharpDom.TestTarget.Structs.NestedStaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
