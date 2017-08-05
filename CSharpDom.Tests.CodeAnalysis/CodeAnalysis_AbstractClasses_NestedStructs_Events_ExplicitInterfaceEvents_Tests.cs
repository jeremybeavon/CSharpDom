using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStructs_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceEventWith1AttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExplicitInterfaceEventWithGenericInterfaceUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
