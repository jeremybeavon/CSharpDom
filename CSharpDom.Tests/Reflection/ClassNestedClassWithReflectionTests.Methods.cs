using CSharpDom.TestTarget.Classes.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWith1GenericParameter()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWith1ReturnAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWith2GenericParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWithGenericParameterBaseClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWithGenericParameterClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWithGenericParameterInterfaceConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWithGenericParameterStructConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithInternalMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewStaticMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewVirtualMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithOverrideMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWithParametersWithAttributes()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithMethodWithParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithPrivateMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithProtectedMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithProtectedInternalMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithPublicMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithSealedOverrideMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithStaticMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithVirtualMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualMethod));
        }
    }
}