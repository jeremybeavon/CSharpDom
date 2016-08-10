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
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithInternalEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithPublicEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithStaticEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticEventProperty));
        }
    }
}
