using CSharpDom.TestTarget.Structs.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPublicEventProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEventProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithVirtualEventProperty));
        }
    }
}
