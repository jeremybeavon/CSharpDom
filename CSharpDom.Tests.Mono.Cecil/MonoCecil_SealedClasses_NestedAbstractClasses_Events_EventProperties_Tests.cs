using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithInternalEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithNewVirtualEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithOverrideEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPrivateEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPublicEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithStaticEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithVirtualEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
