using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedSealedClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
