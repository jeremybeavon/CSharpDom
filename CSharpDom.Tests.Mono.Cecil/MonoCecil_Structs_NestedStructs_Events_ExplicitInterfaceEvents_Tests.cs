using CSharpDom.TestTarget.Structs.NestedStructs.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventWith1AccessorAttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventWithGenericDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitInterfaceEventWithGenericInterfaceUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
