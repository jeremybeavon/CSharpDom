using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStructs_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExplicitInterfaceEventWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExplicitInterfaceEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExplicitInterfaceEventWithGenericInterfaceUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
