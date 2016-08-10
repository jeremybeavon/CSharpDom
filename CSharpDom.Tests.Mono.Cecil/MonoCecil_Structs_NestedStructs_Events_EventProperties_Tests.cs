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
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithInternalEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPublicEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithStaticEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithStaticEventProperty));
        }
    }
}
