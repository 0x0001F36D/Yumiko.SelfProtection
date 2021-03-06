﻿
namespace Yumiko.SelfProtection.Infrastructure.Internal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Yumiko.SelfProtection.Infrastructure.Contract;

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class Transpiler<T> : ITranspiler<T>
    {
        private readonly Func<IDictionary<string, object>> _builder;

        internal Transpiler(Func<IDictionary<string, object>> builder)
        {
            this._builder = builder;
        }

        IDictionary<string, object> ITranspiler<T>.Create()
        {
            return this._builder();
        }

        T ITranspiler<T>.Convert(IDictionary<string, object> dict)
        {
            return (T)dict;
        }
    }
}
