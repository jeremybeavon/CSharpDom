using CSharpDom.TestTarget.StaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithEventWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventWithGenericDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicEventUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicEvent));
        }
    }
}
