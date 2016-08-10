using CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStaticClasses_Events_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithEventWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithEventWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithInternalEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPrivateEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStaticClassWithPublicEventUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStaticClassWithPublicEvent));
        }
    }
}
