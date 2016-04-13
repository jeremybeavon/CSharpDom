using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedAbstractClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWith1GenericParameter()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWith1ReturnAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWith2GenericParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithInternalMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewStaticMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewVirtualMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithOverrideMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWithParametersWithAttributes()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithMethodWithParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithPrivateMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithProtectedMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithProtectedInternalMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithPublicMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithSealedOverrideMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithStaticMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithVirtualMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualMethod));
        }
    }
}