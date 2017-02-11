using CSharpDom.TestTarget.Classes.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithEventWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicEventUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicEvent));
        }
    }
}
