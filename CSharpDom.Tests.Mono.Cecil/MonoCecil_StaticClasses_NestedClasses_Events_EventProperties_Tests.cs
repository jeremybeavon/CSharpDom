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
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestStaticClassWithNestedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
