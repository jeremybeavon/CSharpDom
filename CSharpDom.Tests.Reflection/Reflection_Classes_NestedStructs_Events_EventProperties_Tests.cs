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
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithInternalEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPrivateEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPublicEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithStaticEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithStaticEventProperty));
        }
    }
}
