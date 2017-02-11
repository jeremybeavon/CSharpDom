using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithEventWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithEventWithGenericDelegateUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithInternalEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPrivateEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPublicEventUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPublicEvent));
        }
    }
}
