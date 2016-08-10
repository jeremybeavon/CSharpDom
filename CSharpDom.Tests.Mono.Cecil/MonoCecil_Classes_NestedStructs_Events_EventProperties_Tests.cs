using CSharpDom.TestTarget.Classes.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticEventPropertyUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticEventProperty));
        }
    }
}
