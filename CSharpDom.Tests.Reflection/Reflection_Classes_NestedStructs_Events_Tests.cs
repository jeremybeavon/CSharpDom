using CSharpDom.TestTarget.Classes.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructsWithEventWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(StructWithNestedStructsWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructsWithEventWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(StructWithNestedStructsWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventWithGenericDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicEventUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicEvent));
        }
    }
}
