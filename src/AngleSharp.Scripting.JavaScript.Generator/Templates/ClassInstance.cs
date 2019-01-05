﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace AngleSharp.Scripting.JavaScript.Generator.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class ClassInstance : ClassInstanceBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("namespace ");
            
            #line 5 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    using ");
            
            #line 7 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.OriginalNamespace));
            
            #line default
            #line hidden
            this.Write(";\r\n    using Jint;\r\n    using Jint.Runtime;\r\n    using Jint.Native;\r\n    using Ji" +
                    "nt.Native.Object;\r\n    using System;\r\n\r\n    partial class ");
            
            #line 14 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance : ");
            
            #line 14 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.BaseName));
            
            #line default
            #line hidden
            this.Write("Instance\r\n    {\r\n        readonly EngineInstance _engine;\r\n\r\n        public ");
            
            #line 18 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance(EngineInstance engine)\r\n            : base(engine");
            
            #line 19 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture((Model.BaseName == "Object" ? ".Jint" : "")));
            
            #line default
            #line hidden
            this.Write(")\r\n        {\r\n            _engine = engine;\r\n");
            
            #line 22 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 foreach (var field in Model.Fields) { 
            
            #line default
            #line hidden
            this.Write("            FastAddProperty(\"");
            
            #line 23 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\", ");
            
            #line 23 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Value));
            
            #line default
            #line hidden
            this.Write(", false, true, false);\r\n");
            
            #line 24 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n        public static ");
            
            #line 27 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance Create");
            
            #line 27 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Object(EngineInstance engine)\r\n        {\r\n            var obj = new ");
            
            #line 29 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("Instance(engine);\r\n            obj.Extensible = true;\r\n            obj.Prototype " +
                    "= engine.Jint.Object.PrototypeObject;            \r\n            return obj;\r\n    " +
                    "    }\r\n\r\n        public override String Class\r\n        {\r\n            get { retu" +
                    "rn \"");
            
            #line 37 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("\"; }\r\n        }\r\n");
            
            #line 39 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 if (Model.Getters.Any()) { 
            
            #line default
            #line hidden
            this.Write("        \r\n        public override JsValue Get(String propertyName)\r\n        {\r\n");
            
            #line 43 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 foreach (var method in Model.Getters) { 
            
            #line default
            #line hidden
            
            #line 44 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 var type = method.Parameters.First().ParameterType; 
            
            #line default
            #line hidden
            
            #line 45 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 if (type == typeof(Int32)) { 
            
            #line default
            #line hidden
            this.Write("            var index = default(Int32);\r\n\r\n            if (Int32.TryParse(propert" +
                    "yName, out index))\r\n");
            
            #line 49 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 if (String.IsNullOrEmpty(method.RefName)) { 
            
            #line default
            #line hidden
            this.Write("                return _engine.GetDomNode(Ref");
            
            #line 50 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("[index]);\r\n");
            
            #line 51 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("                return _engine.GetDomNode(Ref");
            
            #line 52 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 52 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.RefName));
            
            #line default
            #line hidden
            this.Write("(index));\r\n");
            
            #line 53 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            
            #line 54 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } else if (type == typeof(String)) { 
            
            #line default
            #line hidden
            this.Write("            if (propertyName != null)\r\n");
            
            #line 56 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 if (String.IsNullOrEmpty(method.RefName)) { 
            
            #line default
            #line hidden
            this.Write("                return _engine.GetDomNode(Ref");
            
            #line 57 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("[propertyName]);\r\n");
            
            #line 58 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("                return _engine.GetDomNode(Ref");
            
            #line 59 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 59 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.RefName));
            
            #line default
            #line hidden
            this.Write("(propertyName));\r\n");
            
            #line 60 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 62 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            
            #line 63 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            return base.Get(propertyName);\r\n        }\r\n\r\n");
            
            #line 67 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            
            #line 68 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 if (Model.Setters.Any()) { 
            
            #line default
            #line hidden
            this.Write("        \r\n        public override void Put(String propertyName, JsValue value, Bo" +
                    "olean throwOnError)\r\n        {\r\n");
            
            #line 72 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 foreach (var method in Model.Setters) { 
            
            #line default
            #line hidden
            
            #line 73 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 var type = method.Parameters.Skip(0).First().ParameterType; 
            
            #line default
            #line hidden
            
            #line 74 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 if (type == typeof(Int32)) { 
            
            #line default
            #line hidden
            this.Write("            var index = default(Int32);\r\n\r\n            if (Int32.TryParse(propert" +
                    "yName, out index))\r\n            {\r\n");
            
            #line 79 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 if (String.IsNullOrEmpty(method.RefName)) { 
            
            #line default
            #line hidden
            this.Write("                Ref");
            
            #line 80 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("[index] = ");
            
            #line 80 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Converter));
            
            #line default
            #line hidden
            this.Write("(value);\r\n");
            
            #line 81 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } else { 
            
            #line default
            #line hidden
            
            #line 82 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 var arg = method.Parameters.Skip(1).First(); 
            
            #line default
            #line hidden
            this.Write("                Ref");
            
            #line 83 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 83 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.RefName));
            
            #line default
            #line hidden
            this.Write("(index, ");
            
            #line 83 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(arg.Converter));
            
            #line default
            #line hidden
            this.Write("(value));\r\n");
            
            #line 84 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            this.Write("                return;\r\n            }\r\n\r\n");
            
            #line 88 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } else if (type == typeof(String)) { 
            
            #line default
            #line hidden
            this.Write("            if (propertyName != null)\r\n            {\r\n");
            
            #line 91 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 if (String.IsNullOrEmpty(method.RefName)) { 
            
            #line default
            #line hidden
            this.Write("                Ref");
            
            #line 92 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("[propertyName] = ");
            
            #line 92 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Converter));
            
            #line default
            #line hidden
            this.Write("(value);\r\n");
            
            #line 93 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } else { 
            
            #line default
            #line hidden
            
            #line 94 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 var arg = method.Parameters.Skip(1).First(); 
            
            #line default
            #line hidden
            this.Write("                Ref");
            
            #line 95 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 95 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.RefName));
            
            #line default
            #line hidden
            this.Write("(propertyName, ");
            
            #line 95 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(arg.Converter));
            
            #line default
            #line hidden
            this.Write("(value));\r\n");
            
            #line 96 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            this.Write("                return;\r\n            }\r\n\r\n");
            
            #line 100 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            
            #line 101 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            base.Put(propertyName, value, throwOnError);\r\n        }\r\n\r\n");
            
            #line 105 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            
            #line 106 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 if (Model.Deleters.Any()) { 
            
            #line default
            #line hidden
            this.Write("        \r\n        public override Boolean Delete(String propertyName, Boolean thr" +
                    "owOnError)\r\n        {\r\n");
            
            #line 110 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 foreach (var method in Model.Deleters) { 
            
            #line default
            #line hidden
            
            #line 111 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 var type = method.Parameters.First().ParameterType; 
            
            #line default
            #line hidden
            
            #line 112 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 if (type == typeof(Int32)) { 
            
            #line default
            #line hidden
            this.Write("            var index = default(Int32);\r\n\r\n            if (Int32.TryParse(propert" +
                    "yName, out index))\r\n            {\r\n                Ref");
            
            #line 117 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 117 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.OriginalName));
            
            #line default
            #line hidden
            this.Write("(propertyName);\r\n                return true;\r\n            }\r\n\r\n");
            
            #line 121 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } else if (type == typeof(String)) { 
            
            #line default
            #line hidden
            this.Write("            if (propertyName != null)\r\n            {\r\n                Ref");
            
            #line 124 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 124 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.OriginalName));
            
            #line default
            #line hidden
            this.Write("(propertyName);\r\n                return true;\r\n            }\r\n\r\n");
            
            #line 128 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            
            #line 129 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            this.Write("            return base.Delete(propertyName, throwOnError);\r\n        }\r\n");
            
            #line 132 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n        public ");
            
            #line 134 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.OriginalName));
            
            #line default
            #line hidden
            
            #line 134 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.GenericArguments));
            
            #line default
            #line hidden
            this.Write(" Ref");
            
            #line 134 "D:\Code\Libraries\AngleSharp.Scripting\AngleSharp.Scripting.JavaScript.Generator\Templates\ClassInstance.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Model.Name));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            get;\r\n            set;\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class ClassInstanceBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
