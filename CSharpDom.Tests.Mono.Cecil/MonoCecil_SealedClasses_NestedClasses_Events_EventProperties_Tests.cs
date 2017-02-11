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
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestSealedClassWithNestedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
