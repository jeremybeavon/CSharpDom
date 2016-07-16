using CSharpDom.TestTarget.SealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverrideEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticEventProperty));
        }
    }
}
