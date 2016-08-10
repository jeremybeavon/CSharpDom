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
            TestClassAsync(typeof(ClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWithGenericInterfaceUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
