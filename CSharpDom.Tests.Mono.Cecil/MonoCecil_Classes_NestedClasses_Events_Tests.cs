using CSharpDom.TestTarget.Classes.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithEventWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEvent));
        }

        //[TestMethod]
        //public async Task TestClassWithNestedClassWithNewVirtualEventUsingMonoCecil()
        //{
        //    await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEvent));
        //}

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverrideEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverrideEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualEvent));
        }
    }
}
