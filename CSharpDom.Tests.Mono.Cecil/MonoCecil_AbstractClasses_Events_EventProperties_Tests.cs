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
            TestAbstractClass(typeof(AbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithVirtualEventProperty));
        }
    }
}
