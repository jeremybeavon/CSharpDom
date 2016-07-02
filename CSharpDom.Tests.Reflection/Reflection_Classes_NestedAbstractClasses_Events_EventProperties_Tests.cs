using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVirtualEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverrideEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverrideEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
