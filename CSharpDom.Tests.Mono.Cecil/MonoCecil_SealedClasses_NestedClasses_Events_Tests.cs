using CSharpDom.TestTarget.SealedClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public async Task TestSealedClassWithNestedClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualEvent));
        }
    }
}
