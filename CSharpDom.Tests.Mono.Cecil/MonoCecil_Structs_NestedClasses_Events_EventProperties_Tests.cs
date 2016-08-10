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
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticEventProperty));
        }

        //[TestMethod]
        //public void TestStructWithNestedClassWithNewVirtualEventPropertyUsingMonoCecil()
        //{
        //    TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEventProperty));
        //}

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualEventProperty));
        }
    }
}
