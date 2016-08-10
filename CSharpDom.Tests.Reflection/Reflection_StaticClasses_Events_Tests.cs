using CSharpDom.TestTarget.StaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithEventWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithInternalEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithPublicEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicEvent));
        }
    }
}
