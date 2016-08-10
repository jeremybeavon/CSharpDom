using CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
