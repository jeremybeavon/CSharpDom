using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedAbstractClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedAbstractClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
