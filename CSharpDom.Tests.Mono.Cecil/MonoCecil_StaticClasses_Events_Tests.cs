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
            TestStaticClassAsync(typeof(StaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithInternalEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithPublicEventUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicEvent));
        }
    }
}
