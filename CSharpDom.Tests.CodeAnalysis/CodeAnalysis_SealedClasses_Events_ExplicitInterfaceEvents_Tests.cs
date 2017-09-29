using CSharpDom.TestTarget.SealedClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithExplicitInterfaceEventWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithExplicitInterfaceEventWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithExplicitInterfaceEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestSealedClassWithExplicitInterfaceEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithExplicitInterfaceEventWithGenericInterfaceUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
