using CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewEventPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
