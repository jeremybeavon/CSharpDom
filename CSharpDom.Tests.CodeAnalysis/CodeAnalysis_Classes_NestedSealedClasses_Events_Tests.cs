using CSharpDom.TestTarget.Classes.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
