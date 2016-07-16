using CSharpDom.TestTarget.Classes.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithInternalEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithOverrideEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithPrivateEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithPublicEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithStaticEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithVirtualEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithVirtualEventProperty));
        }
    }
}
