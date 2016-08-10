using CSharpDom.TestTarget.SealedClasses.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithInternalEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPrivateEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPublicEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithStaticEventPropertyUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithStaticEventProperty));
        }
    }
}
