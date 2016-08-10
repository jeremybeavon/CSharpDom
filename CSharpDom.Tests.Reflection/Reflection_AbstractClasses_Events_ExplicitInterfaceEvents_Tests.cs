using CSharpDom.TestTarget.AbstractClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithExplicitInterfaceEventWith1AccessorAttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithExplicitInterfaceEventWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWith1Attribute));
        }
        
        [TestMethod]
        public void TestAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }
        
        [TestMethod]
        public void TestAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithExplicitInterfaceEventUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithExplicitInterfaceEventWithGenericDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithExplicitInterfaceEventWithGenericInterfaceUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
