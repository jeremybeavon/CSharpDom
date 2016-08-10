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
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticEventPropertyUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
