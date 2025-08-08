using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using underware.Edi.Common.DocumentModel;
using underware.VDA.Messages;
using underware.VDA.Models;
using underware.VDA.Records;

namespace underware.VDA;

public static class Extensions
{

    public static Delivery GetAt(this IList<Delivery> list, int index)
    {
        return list.Count <= index ? null : list[index];       
    }
    
    public static string GetVdaDate(this Delivery delivery)
    {
        if(delivery.EndDate.HasValue)
            return GetVdaDate(delivery.Date, delivery.EndDate.Value);
        
        return delivery.SpecialMeaning switch
        {
            SpecialDateMeaning.None => delivery.Date.ToVdaDate(),
            SpecialDateMeaning.EndOfCallOff => "000000",
            SpecialDateMeaning.NoRequirement => "222222",
            SpecialDateMeaning.Backlog => "333333",
            SpecialDateMeaning.Immediate => "444444",
            SpecialDateMeaning.SwitchToWeeklyMonthly => "555555",
            SpecialDateMeaning.Remaining => "999999",
            _ => delivery.Date.ToVdaDate()
        };
    }

    public static SpecialDateMeaning GetSpecialMeaning(this DateQtyPair pair)
    {
        return pair.Date switch
        {
            "000000" => SpecialDateMeaning.EndOfCallOff,
            "222222" => SpecialDateMeaning.NoRequirement,
            "333333" => SpecialDateMeaning.Backlog,
            "444444" => SpecialDateMeaning.Immediate,
            "555555" => SpecialDateMeaning.SwitchToWeeklyMonthly,
            "999999" => SpecialDateMeaning.Remaining,
            _ => SpecialDateMeaning.None
        };
    }

    private static string GetVdaDate(DateTime start, DateTime end)
    {
        return end.Subtract(start).Days == 6 
            ? $"{start:yy}00{start.GetIso8601WeekOfYear():00}" 
            : $"{start:yy}{start.GetIso8601WeekOfYear():00}{end.GetIso8601WeekOfYear():00}";

        //return end.AddMonths(-1) == start ? $"{start:yy}{start.Month:00}00" : start.ToVdaDate();
    }
    
    public static int GetIso8601WeekOfYear(this DateTime date)
    {
        // ISO 8601 weeks start on Monday
        var day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(date);
        if (day is >= DayOfWeek.Monday and <= DayOfWeek.Wednesday)
        {
            // Adjust to ensure the week belongs to the correct year
            date = date.AddDays(3);
        }

        return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date,
            CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
    }
    
    


    public static string ToVdaDate(this DateTime date)
    {
        return date.ToString("yyMMdd");
    }

    public static string ToVdaTime(this DateTime date)
    {
        return date.ToString("HHmm");
    }
    
    public static string ToVda(this decimal value, int decimals = 3)
    {
        var multiplier = (decimal)Math.Pow(10, decimals);
        return (value * multiplier).ToString("0", CultureInfo.InvariantCulture);
    }
    
    public static string ToVda(this decimal? value, int decimals = 3)
    {
        return value.HasValue ? value.Value.ToVda(decimals) : string.Empty;
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
        return string.IsNullOrEmpty(s) ? 0m : decimal.Parse(s, CultureInfo.InvariantCulture);
    }
}