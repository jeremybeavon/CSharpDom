using CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
