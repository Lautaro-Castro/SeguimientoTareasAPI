using System;
using System.ComponentModel;
using Microsoft.AspNetCore.Identity;
using System.Reflection;

namespace SeguimientoTareasAPI.Helpers.Extentions;

public static class EnumExtensions
{
    public static string GetDescription(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
        return attribute?.Description ?? value.ToString();
    }
}
