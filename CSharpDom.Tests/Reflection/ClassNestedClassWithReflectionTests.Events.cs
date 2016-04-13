using CSharpDom.TestTarget.Classes.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithEventWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithEventWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithEventWithGenericDelegate()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithInternalEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewStaticEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewVirtualEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithOverrideEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithPrivateEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithProtectedEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithProtectedInternalEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithPublicEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithSealedOverrideEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithStaticEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithVirtualEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualEvent));
        }
    }
}