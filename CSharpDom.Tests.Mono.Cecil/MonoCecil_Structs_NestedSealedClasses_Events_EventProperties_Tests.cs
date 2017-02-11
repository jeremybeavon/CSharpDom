using CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
