using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public async Task TestClassWithNestedAbstractClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverrideEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverrideEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
