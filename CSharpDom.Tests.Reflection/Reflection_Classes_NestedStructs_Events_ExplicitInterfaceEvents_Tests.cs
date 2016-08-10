using CSharpDom.TestTarget.Classes.NestedStructs.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceEventWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExplicitInterfaceEventWithGenericInterfaceUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
