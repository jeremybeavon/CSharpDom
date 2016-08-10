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
            TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithPublicEventProperty));
        }
    }
}
