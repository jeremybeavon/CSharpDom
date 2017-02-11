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
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestAbstractClassWithNestedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
