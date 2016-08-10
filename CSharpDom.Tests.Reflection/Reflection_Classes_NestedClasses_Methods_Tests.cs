using CSharpDom.TestTarget.Classes.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith1AttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualMethodUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithVirtualMethod));
        }
    }
}
