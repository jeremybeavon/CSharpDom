using CSharpDom.TestTarget.Classes.NestedClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceEventWith1AccessorAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceEventWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceEvent()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceEventWithGenericDelegate()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithExplicitInterfaceEventWithGenericInterface()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}