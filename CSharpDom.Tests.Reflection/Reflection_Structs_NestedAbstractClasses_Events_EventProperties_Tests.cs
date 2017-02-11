using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
