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
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
