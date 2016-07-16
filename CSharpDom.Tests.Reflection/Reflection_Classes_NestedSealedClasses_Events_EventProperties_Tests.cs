using CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Events_EventProperties_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithEventPropertyWith1AccessorAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithEventPropertyWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithEventPropertyWithGenericDelegateUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOverrideEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithSealedOverrideEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticEventPropertyUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticEventProperty));
        }
    }
}
