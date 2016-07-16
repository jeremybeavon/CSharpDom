using CSharpDom.TestTarget.AbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualEventProperty));
        }
    }
}
