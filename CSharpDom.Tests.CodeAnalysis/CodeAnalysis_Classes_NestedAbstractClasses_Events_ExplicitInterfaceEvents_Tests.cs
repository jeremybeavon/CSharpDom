using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedAbstractClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceEventWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterfaceUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
