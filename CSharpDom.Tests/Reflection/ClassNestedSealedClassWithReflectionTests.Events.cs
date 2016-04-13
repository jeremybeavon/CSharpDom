using CSharpDom.TestTarget.Classes.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedSealedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithEventWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithEventWithGenericDelegate()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithInternalEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithNewEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithNewStaticEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticEvent));
        }
        
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithOverrideEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithPrivateEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithProtectedEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithProtectedInternalEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithPublicEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithSealedOverrideEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithStaticEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticEvent));
        }
    }
}