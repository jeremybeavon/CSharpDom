using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedAbstractClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithInternalEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithNewVirtualEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOverrideEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPrivateEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPublicEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithStaticEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithVirtualEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
