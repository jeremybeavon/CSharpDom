using CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticMethod));
        }
    }
}
