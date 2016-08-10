using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
