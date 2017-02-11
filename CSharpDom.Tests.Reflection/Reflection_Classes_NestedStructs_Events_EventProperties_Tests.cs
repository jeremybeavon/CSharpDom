using CSharpDom.TestTarget.Classes.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithStaticEventProperty));
        }
    }
}
