using CSharpDom.TestTarget.Structs.NestedStaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStaticClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicEventPropertyUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
