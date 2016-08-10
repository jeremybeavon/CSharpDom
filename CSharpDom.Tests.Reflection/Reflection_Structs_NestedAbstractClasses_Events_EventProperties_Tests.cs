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
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
