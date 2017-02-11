using CSharpDom.TestTarget.Classes.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith1AccessorAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWithGenericInterfaceUsingReflection()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
