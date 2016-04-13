using CSharpDom.TestTarget.Classes.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedClassWithReflectionTests
    {

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithEventPropertyWith1AccessorAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithEventPropertyWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithEventPropertyWithGenericDelegate()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithInternalEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewStaticEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewVirtualEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithOverrideEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithPrivateEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithProtectedEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithProtectedInternalEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithPublicEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithSealedOverrideEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithStaticEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithVirtualEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualEventProperty));
        }
    }
}