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
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithInternalMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithNewStaticMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOverrideMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPrivateMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithProtectedInternalMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPublicMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithSealedOverrideMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithStaticMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithStaticMethod));
        }
    }
}
