using CSharpDom.TestTarget.Structs.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicEvent));
        }
    }
}
