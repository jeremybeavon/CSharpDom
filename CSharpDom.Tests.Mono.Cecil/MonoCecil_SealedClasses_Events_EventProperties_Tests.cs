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
            TestSealedClass(typeof(SealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithStaticEventProperty));
        }
    }
}
