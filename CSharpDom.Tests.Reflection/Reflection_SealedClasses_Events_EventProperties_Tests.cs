using CSharpDom.TestTarget.SealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithInternalEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPublicEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithStaticEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithStaticEventProperty));
        }
    }
}
