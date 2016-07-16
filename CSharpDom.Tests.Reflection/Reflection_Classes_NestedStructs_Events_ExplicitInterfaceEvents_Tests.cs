using CSharpDom.TestTarget.Classes.NestedStructs.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceEventWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExplicitInterfaceEventWithGenericInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
