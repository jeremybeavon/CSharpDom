using CSharpDom.TestTarget.StaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalEventPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateEventPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicEventPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicEventProperty));
        }
    }
}
