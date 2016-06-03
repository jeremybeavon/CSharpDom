using CSharpDom.TestTarget.Classes.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
