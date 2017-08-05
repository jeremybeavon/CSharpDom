using CSharpDom.TestTarget.Structs.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStaticClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicEvent));
        }
    }
}
