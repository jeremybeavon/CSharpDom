using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
