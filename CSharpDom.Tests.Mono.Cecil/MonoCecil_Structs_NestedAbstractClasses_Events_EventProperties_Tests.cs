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
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedAbstractClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}
