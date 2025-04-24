using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using underware.VDA.Messages;
using underware.VDA.Models;
using underware.VDA.Records;

namespace underware.VDA;

public static class Extensions
{

    public static string ToVdaDate(this DateTime date)
    {
        return date.ToString("yyMMdd");
    }

    public static string ToVdaTime(this DateTime date)
    {
        return date.ToString("HHmm");
    }
    
    public static List<DateQtyPair> GetDeliveries(this Record record)
    {
        List<DateQtyPair> deliveries = [];
        
        var type = record.GetType();
        var qtyProperties = type.GetProperties().Where(p => p.Name.Contains("_CallOffQty"));
        var dateProperties = type.GetProperties().Where(p => p.Name.Contains("_CallOffDate"));

        foreach (var qtyProperty in qtyProperties)
        {
            var index = qtyProperty.Name.Substring(15);
            var dateProperty = dateProperties.FirstOrDefault(p => p.Name.EndsWith($"_CallOffDate{index}"));
            deliveries.Add(new DateQtyPair()
            {
                Quantity = qtyProperty.GetValue(record).ToString(), Date = dateProperty?.GetValue(record).ToString()
            });
        }
        
        return deliveries;
    }
    
    
    public static bool Is(this IParent parent, Type type)
    {
        var parentType = parent.GetType();
        
        return type.IsInterface
            ? parentType.GetInterfaces().Contains(type)
            : parentType == type;
    }
    
    public static bool IsDate(this string s)
    {
        return DateTime.TryParseExact(s, "yyMMdd", null, DateTimeStyles.None, out var date);
    }
    
    public static DateTime? TryParseDate(this string s)
    {
        return DateTime.TryParseExact(s, "yyMMdd", null,  DateTimeStyles.None, out var date) ? date : null;
    }
    
    public static DateTime ParseDate(this string s)
    {
        return DateTime.ParseExact(s, "yyMMdd", null);
    }
    
    public static DateTime ParseDateTime(this string s)
    {
        return DateTime.ParseExact(s, "yyMMddHHmm", null);
    }
    
    public static decimal ParseDecimal(this string s)
    {
        return decimal.Parse(s, CultureInfo.InvariantCulture);
    }
}