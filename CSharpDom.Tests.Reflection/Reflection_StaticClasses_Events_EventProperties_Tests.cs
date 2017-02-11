using CSharpDom.TestTarget.StaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithInternalEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPrivateEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestStaticClassWithPublicEventPropertyUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithPublicEventProperty));
        }
    }
}
