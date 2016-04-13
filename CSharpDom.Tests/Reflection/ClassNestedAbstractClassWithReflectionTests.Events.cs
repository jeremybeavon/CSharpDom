using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedAbstractClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithEventWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithEventWithGenericDelegate()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithInternalEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewStaticEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewVirtualEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithOverrideEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithPrivateEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithProtectedEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithProtectedInternalEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithPublicEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithSealedOverrideEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithStaticEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithVirtualEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}