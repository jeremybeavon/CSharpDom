using CSharpDom.TestTarget.Structs.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructsWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructsWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicEvent));
        }
    }
}
