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
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventWithGenericDelegateUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicEvent));
        }
    }
}
