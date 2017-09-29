using CSharpDom.TestTarget.SealedClasses.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicEvent));
        }
    }
}
