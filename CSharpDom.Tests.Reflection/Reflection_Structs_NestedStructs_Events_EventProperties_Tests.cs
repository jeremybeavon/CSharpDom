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
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticEventProperty));
        }
    }
}
