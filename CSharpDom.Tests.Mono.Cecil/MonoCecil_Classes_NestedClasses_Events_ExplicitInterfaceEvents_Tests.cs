using CSharpDom.TestTarget.Classes.NestedClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceEventWith1AccessorAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceEventWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceEventUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceEventWithGenericDelegateUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceEventWithGenericInterfaceUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
