using CSharpDom.TestTarget.Classes.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithInternalEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithOverrideEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithPrivateEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithPublicEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithStaticEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithVirtualEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithVirtualEventProperty));
        }
    }
}
