using CSharpDom.TestTarget.Classes.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStaticClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
