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
            TestStruct(typeof(StructWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
