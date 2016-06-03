using CSharpDom.TestTarget.Structs.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithStaticEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithStaticEventProperty));
        }
    }
}
