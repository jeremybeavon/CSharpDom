using CSharpDom.TestTarget.StaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithInternalEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithPublicEventUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithPublicEvent));
        }
    }
}
