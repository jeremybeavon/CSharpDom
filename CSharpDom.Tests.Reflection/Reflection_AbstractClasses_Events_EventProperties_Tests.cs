using CSharpDom.TestTarget.AbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalEventPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewEventPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticEventPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualEventPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideEventPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateEventPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedEventPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalEventPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicEventPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideEventPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticEventPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualEventPropertyUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
