using CSharpDom.TestTarget.Structs.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualEventProperty));
        }
    }
}
