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
            TestClass(typeof(ClassWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicEvent));
        }
    }
}
