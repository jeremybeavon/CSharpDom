using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedStaticClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventWith1AttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicEventUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
