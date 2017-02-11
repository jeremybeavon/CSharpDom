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
            TestAbstractClass(typeof(AbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithEventPropertyWith1Attribute));
        }
        
        [TestMethod]
        public void TestAbstractClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualEventPropertyUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithVirtualEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }
    }
}
