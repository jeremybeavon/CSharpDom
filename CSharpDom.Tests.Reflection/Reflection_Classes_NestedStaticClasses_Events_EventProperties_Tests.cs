using CSharpDom.TestTarget.Classes.NestedStaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicEventPropertyUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
