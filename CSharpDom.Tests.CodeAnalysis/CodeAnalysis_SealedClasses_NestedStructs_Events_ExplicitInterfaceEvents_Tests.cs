using CSharpDom.TestTarget.SealedClasses.NestedStructs.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceEventWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceEventWithGenericInterfaceUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
