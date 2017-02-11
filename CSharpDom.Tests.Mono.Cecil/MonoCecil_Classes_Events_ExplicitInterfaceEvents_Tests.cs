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
            TestClass(typeof(ClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith1AttributeUsingMonoCecil()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventUsingMonoCecil()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWithGenericDelegateUsingMonoCecil()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithExplicitInterfaceEventWithGenericInterfaceUsingMonoCecil()
        {
            TestClass(typeof(ClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
