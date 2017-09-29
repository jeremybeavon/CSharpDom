using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStaticClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivateEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
