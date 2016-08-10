using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedSealedClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
