using CSharpDom.TestTarget.StaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithInternalEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithPublicEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicEvent));
        }
    }
}
