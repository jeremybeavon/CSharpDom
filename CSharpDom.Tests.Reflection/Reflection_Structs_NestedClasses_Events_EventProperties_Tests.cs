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
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualEventProperty));
        }
    }
}
