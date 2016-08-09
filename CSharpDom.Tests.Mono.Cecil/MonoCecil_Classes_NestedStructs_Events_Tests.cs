using CSharpDom.TestTarget.Classes.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithEventWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicEvent));
        }
    }
}
