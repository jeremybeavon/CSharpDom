using CSharpDom.TestTarget.Structs.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticEventProperty));
        }
    }
}
