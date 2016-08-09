using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public async Task TestStructWithNestedAbstractClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverrideEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualEventPropertyUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
