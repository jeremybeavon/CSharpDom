using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceEventWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
