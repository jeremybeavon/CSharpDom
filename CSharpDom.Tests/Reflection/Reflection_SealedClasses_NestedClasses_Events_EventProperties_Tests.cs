using CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
