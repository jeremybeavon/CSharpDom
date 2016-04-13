using CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedSealedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWith1GenericParameter()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWith1ReturnAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWith2GenericParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWithGenericParameterClassConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWithGenericParameterStructConstraint()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithInternalMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithNewMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithNewStaticMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithOverrideMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWithParametersWithAttributes()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithMethodWithParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithPrivateMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithProtectedMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithProtectedInternalMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithPublicMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithSealedOverrideMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithStaticMethod()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticMethod));
        }
    }
}