using CSharpDom.TestTarget.Classes.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith1AccessorAttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith1AttributeUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWithGenericDelegateUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWithGenericInterfaceUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
