using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithInternalEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewStaticEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithOverrideEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPrivateEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPublicEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithStaticEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithVirtualEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
