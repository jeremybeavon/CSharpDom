using CSharpDom.TestTarget.Classes.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithInternalEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNewEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNewVirtualEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestClassWithOverrideEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithPrivateEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithProtectedEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithPublicEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithStaticEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithVirtualEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithVirtualEvent));
        }
    }
}
