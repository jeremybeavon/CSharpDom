using CSharpDom.TestTarget.Classes.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualEvent));
        }
    }
}
