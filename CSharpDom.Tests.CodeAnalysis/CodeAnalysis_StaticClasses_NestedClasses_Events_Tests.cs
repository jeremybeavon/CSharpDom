using CSharpDom.TestTarget.StaticClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualEvent));
        }
    }
}
