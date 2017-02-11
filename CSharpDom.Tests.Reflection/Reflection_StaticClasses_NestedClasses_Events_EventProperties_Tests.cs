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
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
