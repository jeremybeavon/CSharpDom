using CSharpDom.TestTarget.Structs.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualEventProperty));
        }
    }
}
