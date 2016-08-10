using CSharpDom.TestTarget.SealedClasses.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticEventPropertyUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticEventProperty));
        }
    }
}
