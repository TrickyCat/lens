﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lens.SyntaxTree.Translations {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class CompilerMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CompilerMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Lens.SyntaxTree.Translations.CompilerMessages", typeof(CompilerMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use object of type &apos;{0}&apos; as a value for parameter of type &apos;{1}&apos;!.
        /// </summary>
        public static string ArgumentTypeMismatch {
            get {
                return ResourceManager.GetString("ArgumentTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add object of type &apos;{0}&apos; to array of type &apos;{1}&apos;!.
        /// </summary>
        public static string ArrayElementTypeMismatch {
            get {
                return ResourceManager.GetString("ArrayElementTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Array initializer must contain at least one object! Use explicit constructor to create an empty array..
        /// </summary>
        public static string ArrayEmpty {
            get {
                return ResourceManager.GetString("ArrayEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Array type cannot be inferred! Use type casting to specify element types..
        /// </summary>
        public static string ArrayTypeUnknown {
            get {
                return ResourceManager.GetString("ArrayTypeUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create a callable object from a method with more than 16 arguments!.
        /// </summary>
        public static string CallableTooManyArguments {
            get {
                return ResourceManager.GetString("CallableTooManyArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delegate types &apos;{0}&apos; and &apos;{1}&apos; do not have matching argument types!.
        /// </summary>
        public static string CastDelegateArgTypesMismatch {
            get {
                return ResourceManager.GetString("CastDelegateArgTypesMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delegate types &apos;{0}&apos; and &apos;{1}&apos; do not have matching return types!.
        /// </summary>
        public static string CastDelegateReturnTypesMismatch {
            get {
                return ResourceManager.GetString("CastDelegateReturnTypesMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot cast a null to type &apos;{0}&apos; because it is a value type!.
        /// </summary>
        public static string CastNullValueType {
            get {
                return ResourceManager.GetString("CastNullValueType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot cast object of type &apos;{0}&apos; to type &apos;{1}&apos;!.
        /// </summary>
        public static string CastTypesMismatch {
            get {
                return ResourceManager.GetString("CastTypesMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This catch clause is unreachable because the previous one catches all exceptions!\.
        /// </summary>
        public static string CatchClauseUnreachable {
            get {
                return ResourceManager.GetString("CatchClauseUnreachable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; has already been used in a catch clause of current try block!.
        /// </summary>
        public static string CatchTypeDuplicate {
            get {
                return ResourceManager.GetString("CatchTypeDuplicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; cannot be used in catch clause because it does not derive from System.Exception!.
        /// </summary>
        public static string CatchTypeNotException {
            get {
                return ResourceManager.GetString("CatchTypeNotException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot closure an implicit variable!.
        /// </summary>
        public static string ClosureImplicit {
            get {
                return ResourceManager.GetString("ClosureImplicit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot closure a ref argument!.
        /// </summary>
        public static string ClosureRef {
            get {
                return ResourceManager.GetString("ClosureRef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code block contains no statements!.
        /// </summary>
        public static string CodeBlockEmpty {
            get {
                return ResourceManager.GetString("CodeBlockEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A declaration of a variable or a constant cannot be the last statement in a code block!.
        /// </summary>
        public static string CodeBlockLastVar {
            get {
                return ResourceManager.GetString("CodeBlockLastVar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No best common type found for return types of condition branches: &apos;{0}&apos; and &apos;{1}&apos; respectively..
        /// </summary>
        public static string ConditionInconsistentTyping {
            get {
                return ResourceManager.GetString("ConditionInconsistentTyping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Constant variables cannot be passed by reference!.
        /// </summary>
        public static string ConstantByRef {
            get {
                return ResourceManager.GetString("ConstantByRef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Constant division by zero!.
        /// </summary>
        public static string ConstantDivisionByZero {
            get {
                return ResourceManager.GetString("ConstantDivisionByZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A constructor must not be marked as static!.
        /// </summary>
        public static string ConstructorStatic {
            get {
                return ResourceManager.GetString("ConstructorStatic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context #{0} does not exist!.
        /// </summary>
        public static string ContextNotFound {
            get {
                return ResourceManager.GetString("ContextNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Context #{0} has been unregistered!.
        /// </summary>
        public static string ContextUnregistered {
            get {
                return ResourceManager.GetString("ContextUnregistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoking a delegate of type &apos;{0}&apos; requires {1} arguments, {2} given instead!.
        /// </summary>
        public static string DelegateArgumentsCountMismatch {
            get {
                return ResourceManager.GetString("DelegateArgumentsCountMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dictionary initializer must contain at least one key-value pair! Use explicit constructor to create an empty dictionary..
        /// </summary>
        public static string DictionaryEmpty {
            get {
                return ResourceManager.GetString("DictionaryEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add a key of type &apos;{0}&apos; to Dictionary&lt;{1}, {2}&gt;!.
        /// </summary>
        public static string DictionaryKeyTypeMismatch {
            get {
                return ResourceManager.GetString("DictionaryKeyTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dictionary type cannot be inferred! Use type casting to specify element types..
        /// </summary>
        public static string DictionaryTypeUnknown {
            get {
                return ResourceManager.GetString("DictionaryTypeUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add a value of type &apos;{0}&apos; to Dictionary&lt;{1}, {2}&gt;!.
        /// </summary>
        public static string DictionaryValueTypeMismatch {
            get {
                return ResourceManager.GetString("DictionaryValueTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; cannot be accessed from static context!.
        /// </summary>
        public static string DynamicMemberFromStaticContext {
            get {
                return ResourceManager.GetString("DynamicMemberFromStaticContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression type cannot be inferred! Please use type casting to specify actual type..
        /// </summary>
        public static string ExpressionNull {
            get {
                return ResourceManager.GetString("ExpressionNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression that returns a value is expected!.
        /// </summary>
        public static string ExpressionVoid {
            get {
                return ResourceManager.GetString("ExpressionVoid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; cannot be used as range limit because it is not an integer!.
        /// </summary>
        public static string ForeachRangeNotInteger {
            get {
                return ResourceManager.GetString("ForeachRangeNotInteger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create a range from expressions of types &apos;{0}&apos; and &apos;{1}&apos;!.
        /// </summary>
        public static string ForeachRangeTypeMismatch {
            get {
                return ResourceManager.GetString("ForeachRangeTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is more than one suitable override of function &apos;{0}&apos;! Please use type casting to specify the exact override..
        /// </summary>
        public static string FunctionInvocationAmbiguous {
            get {
                return ResourceManager.GetString("FunctionInvocationAmbiguous", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No function named &apos;{0}&apos; with suitable arguments is declared!.
        /// </summary>
        public static string FunctionNotFound {
            get {
                return ResourceManager.GetString("FunctionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of generic arguments does not match!.
        /// </summary>
        public static string GenericArgCountMismatch {
            get {
                return ResourceManager.GetString("GenericArgCountMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generic argument &apos;{0}&apos; has mismatched values: &apos;{1}&apos; and &apos;{2}&apos;!.
        /// </summary>
        public static string GenericArgMismatch {
            get {
                return ResourceManager.GetString("GenericArgMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot apply generic arguments to non-generic method &apos;{0}&apos;!.
        /// </summary>
        public static string GenericArgsToNonGenericMethod {
            get {
                return ResourceManager.GetString("GenericArgsToNonGenericMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generic argument &apos;{0}&apos; could not be resolved!.
        /// </summary>
        public static string GenericArgumentNotResolved {
            get {
                return ResourceManager.GetString("GenericArgumentNotResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; cannot be used as value for generic argument &apos;{1}&apos; of type &apos;{2}&apos; because it is not a reference type!.
        /// </summary>
        public static string GenericClassConstraintViolated {
            get {
                return ResourceManager.GetString("GenericClassConstraintViolated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; cannot be used as value for generic argument &apos;{1}&apos; of type &apos;{2}&apos; because it does not have a default constructor!.
        /// </summary>
        public static string GenericConstructorConstraintViolated {
            get {
                return ResourceManager.GetString("GenericConstructorConstraintViolated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generic argument &apos;{0}&apos; was has hint type &apos;{1}&apos;, but inferred type was &apos;{2}&apos;!.
        /// </summary>
        public static string GenericHintMismatch {
            get {
                return ResourceManager.GetString("GenericHintMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot resolve arguments of &apos;{0}&apos; using type &apos;{1}&apos;!.
        /// </summary>
        public static string GenericImplementationWrongType {
            get {
                return ResourceManager.GetString("GenericImplementationWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; cannot be used as value for generic argument &apos;{1}&apos; of type &apos;{2}&apos; because it does not implement class or interface &apos;{3}&apos;!.
        /// </summary>
        public static string GenericInheritanceConstraintViolated {
            get {
                return ResourceManager.GetString("GenericInheritanceConstraintViolated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot infer argument types of &apos;{0}&apos;: type &apos;{1}&apos; implements multiple overrides!.
        /// </summary>
        public static string GenericInterfaceMultipleImplementations {
            get {
                return ResourceManager.GetString("GenericInterfaceMultipleImplementations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; does not implement any kind of interface &apos;{1}&apos;!.
        /// </summary>
        public static string GenericInterfaceNotImplemented {
            get {
                return ResourceManager.GetString("GenericInterfaceNotImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generic parameter &apos;{0}&apos; was not found!.
        /// </summary>
        public static string GenericParameterNotFound {
            get {
                return ResourceManager.GetString("GenericParameterNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; cannot be used as value for generic argument &apos;{1}&apos; of type &apos;{2}&apos; because it is not a value type!.
        /// </summary>
        public static string GenericStructConstraintViolated {
            get {
                return ResourceManager.GetString("GenericStructConstraintViolated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Global property &apos;{0}&apos; has no getter!.
        /// </summary>
        public static string GlobalPropertyNoGetter {
            get {
                return ResourceManager.GetString("GlobalPropertyNoGetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Global property &apos;{0}&apos; has no setter!.
        /// </summary>
        public static string GlobalPropertyNoSetter {
            get {
                return ResourceManager.GetString("GlobalPropertyNoSetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot assign a value of type &apos;{0}&apos; to a global property of type &apos;{1}&apos;! An explicit cast might be required..
        /// </summary>
        public static string GlobalPropertyTypeMismatch {
            get {
                return ResourceManager.GetString("GlobalPropertyTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a constant and cannot be assigned after definition!.
        /// </summary>
        public static string IdentifierIsConstant {
            get {
                return ResourceManager.GetString("IdentifierIsConstant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No local variable or global parameterless function named &apos;{0}&apos; was found!.
        /// </summary>
        public static string IdentifierNotFound {
            get {
                return ResourceManager.GetString("IdentifierNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot assign a value of type &apos;{0}&apos; to a variable of type &apos;{1}&apos;! An explicit cast might be required..
        /// </summary>
        public static string IdentifierTypeMismatch {
            get {
                return ResourceManager.GetString("IdentifierTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot implicitly convert an object of type &apos;{0}&apos; to required type &apos;{1}&apos;!.
        /// </summary>
        public static string ImplicitCastImpossible {
            get {
                return ResourceManager.GetString("ImplicitCastImpossible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entities cannot be imported into a saveable assembly!.
        /// </summary>
        public static string ImportIntoSaveableAssembly {
            get {
                return ResourceManager.GetString("ImportIntoSaveableAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only public, static, non-generic methods can be imported!.
        /// </summary>
        public static string ImportUnsupportedMethod {
            get {
                return ResourceManager.GetString("ImportUnsupportedMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indexer is ambigious! At least two cases apply:{3}{0}[{1}]{3}{0}[{2}].
        /// </summary>
        public static string IndexAmbigious {
            get {
                return ResourceManager.GetString("IndexAmbigious", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; has no index getter that accepts an index of type &apos;{1}&apos;!.
        /// </summary>
        public static string IndexGetterNotFound {
            get {
                return ResourceManager.GetString("IndexGetterNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; has no index setter that accepts an index of type &apos;{1}&apos;!.
        /// </summary>
        public static string IndexSetterNotFound {
            get {
                return ResourceManager.GetString("IndexSetterNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lambda return type cannot be inferred! Please use type casting to specify type..
        /// </summary>
        public static string LambdaReturnTypeUnknown {
            get {
                return ResourceManager.GetString("LambdaReturnTypeUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add object of type &apos;{0}&apos; to List&lt;{1}&gt;!.
        /// </summary>
        public static string ListElementTypeMismatch {
            get {
                return ResourceManager.GetString("ListElementTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List initializer must contain at least one object! Use explicit constructor to create an empty list..
        /// </summary>
        public static string ListEmpty {
            get {
                return ResourceManager.GetString("ListEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List type cannot be inferred! Use type casting to specify element types..
        /// </summary>
        public static string ListTypeUnknown {
            get {
                return ResourceManager.GetString("ListTypeUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot apply operator &apos;{0}&apos; to arguments of types &apos;{1}&apos; and &apos;{2}&apos;!.
        /// </summary>
        public static string OperatorBinaryTypesMismatch {
            get {
                return ResourceManager.GetString("OperatorBinaryTypesMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot apply apply math operations to arguments of different signedness!.
        /// </summary>
        public static string OperatorTypesSignednessMismatch {
            get {
                return ResourceManager.GetString("OperatorTypesSignednessMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot apply operator &apos;{0}&apos; to argument of type &apos;{1}&apos;!.
        /// </summary>
        public static string OperatorUnaryTypeMismatch {
            get {
                return ResourceManager.GetString("OperatorUnaryTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A parameterless constructor must be invoked by applying a () to it!.
        /// </summary>
        public static string ParameterlessConstructorParens {
            get {
                return ResourceManager.GetString("ParameterlessConstructorParens", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property #{0} has no getter!.
        /// </summary>
        public static string PropertyIdNoGetter {
            get {
                return ResourceManager.GetString("PropertyIdNoGetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property #{0} has no setter!.
        /// </summary>
        public static string PropertyIdNoSetter {
            get {
                return ResourceManager.GetString("PropertyIdNoSetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property #{0} does not exist!.
        /// </summary>
        public static string PropertyIdNotFound {
            get {
                return ResourceManager.GetString("PropertyIdNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &apos;{0}&apos; has already been imported!.
        /// </summary>
        public static string PropertyImported {
            get {
                return ResourceManager.GetString("PropertyImported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &apos;{0}.{1}&apos; does not have a getter!.
        /// </summary>
        public static string PropertyNoGetter {
            get {
                return ResourceManager.GetString("PropertyNoGetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &apos;{0}.{1}&apos; does not have a setter!.
        /// </summary>
        public static string PropertyNoSetter {
            get {
                return ResourceManager.GetString("PropertyNoSetter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument {0} requires a reference of type &apos;{1}&apos;!.
        /// </summary>
        public static string ReferenceArgExpected {
            get {
                return ResourceManager.GetString("ReferenceArgExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use reference as a value for non-reference argument!.
        /// </summary>
        public static string ReferenceArgUnexpected {
            get {
                return ResourceManager.GetString("ReferenceArgUnexpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Function of type &apos;{0}&apos; cannot return an expression of type &apos;{1}&apos;!.
        /// </summary>
        public static string ReturnTypeMismatch {
            get {
                return ResourceManager.GetString("ReturnTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression is expected! An exception can only be rethrown from a catch clause..
        /// </summary>
        public static string ThrowArgumentExpected {
            get {
                return ResourceManager.GetString("ThrowArgumentExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; cannot be used in throw statement because it does not derive from System.Exception!.
        /// </summary>
        public static string ThrowTypeNotException {
            get {
                return ResourceManager.GetString("ThrowTypeNotException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tuple must contain at least one object!.
        /// </summary>
        public static string TupleNoArgs {
            get {
                return ResourceManager.GetString("TupleNoArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tuples cannot contain more than 8 objects! Use a structure or a nested tuple instead..
        /// </summary>
        public static string TupleTooManyArgs {
            get {
                return ResourceManager.GetString("TupleTooManyArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create an instance of type &apos;{0}&apos; because it is abstract!.
        /// </summary>
        public static string TypeAbstract {
            get {
                return ResourceManager.GetString("TypeAbstract", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type arguments cannot be applied to &apos;{0}.{1}&apos; because it is not a method!.
        /// </summary>
        public static string TypeArgumentsForNonMethod {
            get {
                return ResourceManager.GetString("TypeArgumentsForNonMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; has more than one suitable constructor! Please specify type casting to specify the exact override..
        /// </summary>
        public static string TypeConstructorAmbiguos {
            get {
                return ResourceManager.GetString("TypeConstructorAmbiguos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; does not have a constructor accepting given arguments!.
        /// </summary>
        public static string TypeConstructorNotFound {
            get {
                return ResourceManager.GetString("TypeConstructorNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; has already been defined!.
        /// </summary>
        public static string TypeDefined {
            get {
                return ResourceManager.GetString("TypeDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; does not have any field, property or method called &apos;{1}&apos;!.
        /// </summary>
        public static string TypeIdentifierNotFound {
            get {
                return ResourceManager.GetString("TypeIdentifierNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ambigious type reference: type &apos;{0}&apos; is found in the following namespaces:{5}{1} in assembly {2}{5}{3} in assembly {4}.
        /// </summary>
        public static string TypeIsAmbiguous {
            get {
                return ResourceManager.GetString("TypeIsAmbiguous", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; has more than one suitable override of &apos;{1}&apos;! Please specify type arguments..
        /// </summary>
        public static string TypeMethodAmbiguous {
            get {
                return ResourceManager.GetString("TypeMethodAmbiguous", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; has more than one suitable override of &apos;{1}&apos;! Please use type casting to specify the exact override..
        /// </summary>
        public static string TypeMethodInvocationAmbiguous {
            get {
                return ResourceManager.GetString("TypeMethodInvocationAmbiguous", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; has no method named &apos;{1}&apos; and no extension method accepting given arguments was found!.
        /// </summary>
        public static string TypeMethodNotFound {
            get {
                return ResourceManager.GetString("TypeMethodNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is not a delegate!.
        /// </summary>
        public static string TypeNotCallable {
            get {
                return ResourceManager.GetString("TypeNotCallable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; could not be resolved!.
        /// </summary>
        public static string TypeNotFound {
            get {
                return ResourceManager.GetString("TypeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; cannot be used in a boolean context!.
        /// </summary>
        public static string TypeNotImplicitlyBoolean {
            get {
                return ResourceManager.GetString("TypeNotImplicitlyBoolean", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is not iterable!.
        /// </summary>
        public static string TypeNotIterable {
            get {
                return ResourceManager.GetString("TypeNotIterable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is not numeric!.
        /// </summary>
        public static string TypeNotNumeric {
            get {
                return ResourceManager.GetString("TypeNotNumeric", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; does not contain a field or a property named &apos;{1}&apos;!.
        /// </summary>
        public static string TypeSettableIdentifierNotFound {
            get {
                return ResourceManager.GetString("TypeSettableIdentifierNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Types &apos;{0}&apos; and &apos;{1}&apos; cannot be compared!.
        /// </summary>
        public static string TypesIncomparable {
            get {
                return ResourceManager.GetString("TypesIncomparable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A variable named &apos;{0}&apos; is already defined!.
        /// </summary>
        public static string VariableDefined {
            get {
                return ResourceManager.GetString("VariableDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A variable named &apos;{0}&apos; does not exist in the scope!.
        /// </summary>
        public static string VariableNotFound {
            get {
                return ResourceManager.GetString("VariableNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create an instance of Unit or Void types!.
        /// </summary>
        public static string VoidTypeDefault {
            get {
                return ResourceManager.GetString("VoidTypeDefault", resourceCulture);
            }
        }
    }
}
