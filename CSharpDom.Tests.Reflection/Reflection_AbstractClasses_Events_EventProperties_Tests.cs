using CSharpDom.TestTarget.AbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith1Attribute));
        }
        
        [TestMethod]
        public void TestAbstractClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
