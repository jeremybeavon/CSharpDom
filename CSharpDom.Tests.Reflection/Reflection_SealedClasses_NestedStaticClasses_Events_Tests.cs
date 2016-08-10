using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStaticClasses_Events_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithEventWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithEventWithGenericDelegateUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivateEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicEventUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
