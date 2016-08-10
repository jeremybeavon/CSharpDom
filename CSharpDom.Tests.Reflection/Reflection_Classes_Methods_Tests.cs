using CSharpDom.TestTarget.Classes.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithMethodWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithInternalMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNewMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNewStaticMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNewVirtualMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestClassWithOverrideMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithPrivateMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithProtectedMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithPublicMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithStaticMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithStaticMethod));
        }

        [TestMethod]
        public void TestClassWithVirtualMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithVirtualMethod));
        }
    }
}
