using CSharpDom.TestTarget.Classes.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithEventWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicEvent));
        }
    }
}
