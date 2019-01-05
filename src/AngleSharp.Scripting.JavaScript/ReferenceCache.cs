namespace AngleSharp.Scripting.JavaScript
{
    using System;
    using System.Runtime.CompilerServices;

    sealed class ReferenceCache
    {
        private readonly ConditionalWeakTable<Object, DomNodeInstance> _references;

        public ReferenceCache()
        {
            _references = new ConditionalWeakTable<Object, DomNodeInstance>();
        }

        public DomNodeInstance GetOrCreate(Object obj, Func<Object, DomNodeInstance> creator)
        {
            return _references.GetValue(obj, creator.Invoke);
        }
    }
}
