using CSharpDom.TestTarget.AbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualEventProperty));
        }
    }
}
