using CSharpDom.TestTarget.Structs.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithStaticEventProperty));
        }
    }
}
