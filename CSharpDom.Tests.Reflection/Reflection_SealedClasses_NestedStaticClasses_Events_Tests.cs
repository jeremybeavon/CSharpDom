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
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithEventWithGenericDelegateUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivateEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicEventUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
