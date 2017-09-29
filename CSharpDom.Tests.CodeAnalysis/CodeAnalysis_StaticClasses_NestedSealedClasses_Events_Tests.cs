using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverrideEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
