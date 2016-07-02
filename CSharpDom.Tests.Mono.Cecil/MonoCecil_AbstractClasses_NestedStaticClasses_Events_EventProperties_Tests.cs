using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStaticClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithInternalEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPrivateEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPublicEventPropertyUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
