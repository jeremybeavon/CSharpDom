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
            TestClass(typeof(ClassWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticEventPropertyUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithStaticEventProperty));
        }
    }
}
