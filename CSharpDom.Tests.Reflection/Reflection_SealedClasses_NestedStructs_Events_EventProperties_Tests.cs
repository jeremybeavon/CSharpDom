using CSharpDom.TestTarget.SealedClasses.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithInternalEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPrivateEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPublicEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithStaticEventPropertyUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticEventProperty));
        }
    }
}
