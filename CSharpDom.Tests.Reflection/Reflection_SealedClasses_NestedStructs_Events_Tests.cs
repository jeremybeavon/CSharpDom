using CSharpDom.TestTarget.SealedClasses.NestedStructs.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventWith1AttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventWithGenericDelegateUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPublicEvent));
        }
    }
}
