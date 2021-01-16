using System;
using UnityEngine;

namespace Rito.CustomAttributes
{
    public enum ReadOnlyOption
    {
        Always,
        EditMode,
        PlayMode
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class ReadonlyAttribute : PropertyAttribute
    {
        public ReadOnlyOption Option { get; set; } = ReadOnlyOption.Always;

        public ReadonlyAttribute() { }
        public ReadonlyAttribute(ReadOnlyOption when) => Option = when;
    }
}