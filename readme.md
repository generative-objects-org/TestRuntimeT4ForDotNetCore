
Check here for more information about using T4 at runtime : https://docs.microsoft.com/en-us/visualstudio/modeling/run-time-text-generation-with-t4-text-templates?view=vs-2019


To make runtime T4 work with .NET Core, please follow this : 

* Make sure the Custom Tool set on your tt template files is TextTemplatingFilePreprocessor and not TextTemplatingFilePreprocessor 
* Add the Nuget Package for System.CodeDom
* You can extended your generated text generation class with a partial class, to be able to pass extra information at execution time