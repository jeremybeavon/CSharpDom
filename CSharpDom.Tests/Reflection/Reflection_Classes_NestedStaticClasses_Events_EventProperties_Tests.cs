using CSharpDom.TestTarget.Classes.NestedStaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStaticClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithInternalEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPrivateEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStaticClassWithPublicEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
