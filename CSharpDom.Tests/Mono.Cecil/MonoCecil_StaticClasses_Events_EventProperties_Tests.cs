using CSharpDom.TestTarget.StaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalEventPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateEventPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicEventPropertyUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicEventProperty));
        }
    }
}
