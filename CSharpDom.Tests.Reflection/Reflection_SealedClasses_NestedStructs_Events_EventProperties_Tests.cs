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
            TestSealedClass(typeof(SealedClassWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWith1AttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticEventPropertyUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithStaticEventProperty));
        }
    }
}
