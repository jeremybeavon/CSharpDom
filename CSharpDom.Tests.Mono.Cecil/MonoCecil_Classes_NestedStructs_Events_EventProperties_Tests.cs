using CSharpDom.TestTarget.Classes.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticEventPropertyUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticEventProperty));
        }
    }
}
