using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedStaticClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithInternalEventPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPrivateEventPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPublicEventPropertyUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
