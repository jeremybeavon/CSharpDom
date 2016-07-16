using CSharpDom.TestTarget.Classes.NestedStructs.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithStaticEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithStaticEventProperty));
        }
    }
}
