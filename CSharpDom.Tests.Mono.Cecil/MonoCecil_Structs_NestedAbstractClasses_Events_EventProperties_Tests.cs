using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
