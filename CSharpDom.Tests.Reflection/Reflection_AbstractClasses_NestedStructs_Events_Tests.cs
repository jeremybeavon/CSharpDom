using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithEventWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithEventWithGenericDelegateUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicEventUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicEvent));
        }
    }
}
