using CSharpDom.TestTarget.Structs.NestedStructs.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceEventWith1AccessorAttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceEventWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceEventUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceEventWithGenericDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExplicitInterfaceEventWithGenericInterfaceUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
