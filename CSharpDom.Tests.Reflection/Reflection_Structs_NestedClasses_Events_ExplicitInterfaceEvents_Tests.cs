using CSharpDom.TestTarget.Structs.NestedClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWith1AccessorAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWithGenericDelegateUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWithGenericInterfaceUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
