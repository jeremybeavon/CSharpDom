using CSharpDom.TestTarget.SealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticEventProperty));
        }
    }
}
