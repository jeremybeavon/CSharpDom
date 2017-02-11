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
            TestClass(typeof(ClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventPropertyWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithInternalEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPrivateEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public void TestClassWithNestedStaticClassWithPublicEventPropertyUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
