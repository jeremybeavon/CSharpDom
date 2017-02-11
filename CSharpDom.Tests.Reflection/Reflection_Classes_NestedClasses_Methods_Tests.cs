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
            TestClass(typeof(ClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithInternalMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewStaticMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithNewVirtualMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOverrideMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPrivateMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithProtectedInternalMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPublicMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithSealedOverrideMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithStaticMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithVirtualMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithVirtualMethod));
        }
    }
}
