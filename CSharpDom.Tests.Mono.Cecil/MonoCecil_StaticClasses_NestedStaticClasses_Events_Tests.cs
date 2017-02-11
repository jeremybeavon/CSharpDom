using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedStaticClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
