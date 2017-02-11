using CSharpDom.TestTarget.Structs.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithVirtualEventProperty));
        }
    }
}
