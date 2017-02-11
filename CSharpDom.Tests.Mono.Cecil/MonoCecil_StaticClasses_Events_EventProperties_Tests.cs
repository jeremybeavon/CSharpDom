using CSharpDom.TestTarget.StaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithPublicEventProperty));
        }
    }
}
