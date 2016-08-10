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
            TestClassAsync(typeof(ClassWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicEvent));
        }
    }
}
