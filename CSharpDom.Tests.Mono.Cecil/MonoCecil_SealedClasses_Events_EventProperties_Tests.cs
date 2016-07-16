using CSharpDom.TestTarget.SealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticEventProperty));
        }
    }
}
