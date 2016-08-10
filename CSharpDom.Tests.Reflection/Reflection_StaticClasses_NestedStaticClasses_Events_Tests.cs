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
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventWithGenericDelegateUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicEventUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
