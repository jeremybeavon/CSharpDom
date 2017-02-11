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
            TestStaticClass(typeof(StaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithInternalEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithPublicEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithPublicEvent));
        }
    }
}
