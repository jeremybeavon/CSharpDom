using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverrideEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
