using CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
