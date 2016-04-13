using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedAbstractClassWithReflectionTests
    {

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithEventPropertyWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithEventPropertyWithGenericDelegate()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithInternalEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewStaticEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewVirtualEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithOverrideEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithPrivateEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithProtectedEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithProtectedInternalEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithPublicEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithSealedOverrideEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithStaticEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithVirtualEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualEventProperty));
        }
    }
}