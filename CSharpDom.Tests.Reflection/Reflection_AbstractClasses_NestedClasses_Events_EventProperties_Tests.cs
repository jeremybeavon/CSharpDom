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
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
