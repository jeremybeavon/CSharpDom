using CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
