using CSharpDom.TestTarget.Structs.NestedStructs.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventWith1AccessorAttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventWithGenericDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventWithGenericInterfaceUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
