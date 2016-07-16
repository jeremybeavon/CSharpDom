using CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverrideEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticEventPropertyUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
