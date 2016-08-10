using CSharpDom.TestTarget.Classes.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
