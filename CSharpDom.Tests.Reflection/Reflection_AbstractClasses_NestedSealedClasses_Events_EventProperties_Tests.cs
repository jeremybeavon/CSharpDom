using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedSealedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOverrideEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
