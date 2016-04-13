using CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedSealedClassWithReflectionTests
    {

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithEventPropertyWith1AccessorAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithEventPropertyWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithEventPropertyWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithEventPropertyWithGenericDelegate()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithInternalEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithNewEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithNewStaticEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticEventProperty));
        }
        
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithOverrideEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithPrivateEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithProtectedEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithProtectedInternalEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithPublicEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithSealedOverrideEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithStaticEventProperty()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticEventProperty));
        }
    }
}