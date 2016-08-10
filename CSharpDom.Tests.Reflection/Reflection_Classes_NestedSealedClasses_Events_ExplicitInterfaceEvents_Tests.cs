using CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceEventWith1AccessorAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceEventWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceEventUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericInterfaceUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
