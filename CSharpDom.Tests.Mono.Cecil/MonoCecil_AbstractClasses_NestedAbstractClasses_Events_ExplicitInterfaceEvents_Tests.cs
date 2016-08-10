using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedAbstractClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWith1AttributeUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceEventUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegateUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterfaceUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
