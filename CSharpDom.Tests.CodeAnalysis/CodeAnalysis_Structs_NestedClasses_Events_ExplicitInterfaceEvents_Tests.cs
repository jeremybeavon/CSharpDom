using CSharpDom.TestTarget.Structs.NestedClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExplicitInterfaceEventWithGenericInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
