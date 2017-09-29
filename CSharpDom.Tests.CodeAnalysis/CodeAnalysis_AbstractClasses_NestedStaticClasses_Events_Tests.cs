using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStaticClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithInternalEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPrivateEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPublicEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
