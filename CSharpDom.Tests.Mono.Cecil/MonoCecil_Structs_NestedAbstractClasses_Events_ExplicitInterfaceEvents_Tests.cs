using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceEventWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceEventUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterfaceUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
