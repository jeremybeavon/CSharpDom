using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStaticClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithInternalEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPrivateEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStaticClassWithPublicEventPropertyUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
