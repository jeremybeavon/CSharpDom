using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedStaticClasses_Events_EventProperties_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventPropertyWith1AccessorAttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventPropertyWith1AttributeUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithInternalEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPrivateEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithNestedStaticClassWithPublicEventPropertyUsingMonoCecil()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
