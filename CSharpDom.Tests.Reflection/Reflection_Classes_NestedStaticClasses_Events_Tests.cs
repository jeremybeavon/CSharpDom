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
            TestClass(typeof(ClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
