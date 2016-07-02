using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVirtualEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverrideEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverrideEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
