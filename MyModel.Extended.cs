using System;
using System.Collections.Generic;
using System.Text;

namespace TestRuntimeT4ForDotNetCore
{
    public partial class MyModel
    {
        private string _myGeneratedClassName;
        public MyModel(string classNameToGenerate)
        {
            _myGeneratedClassName = classNameToGenerate;
        }

    }
}
