using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStaticClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithInternalEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPrivateEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStaticClassWithPublicEventPropertyUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
