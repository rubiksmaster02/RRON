﻿using System.ComponentModel;

namespace RRON_new
{
    public static partial class ValueSetter
    {
        public static void SetProperty<T>(this string match, ref T instance)
        {
            match.PropertyDeconstruction(out string name, out string value);
            property = Type.GetProperty(name);
            
            property.SetValue(instance, TypeDescriptor.GetConverter(property.PropertyType).ConvertFromString(value));
        }
    }
}