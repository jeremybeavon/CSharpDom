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
            TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithInternalEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPrivateEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStaticClassWithPublicEventPropertyUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
