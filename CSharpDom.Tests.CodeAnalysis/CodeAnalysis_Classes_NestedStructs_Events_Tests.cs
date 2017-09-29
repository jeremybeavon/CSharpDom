using CSharpDom.TestTarget.Classes.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicEventUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicEvent));
        }
    }
}
